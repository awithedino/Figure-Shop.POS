using FigureShop.POS.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace FigureShop.POS.Data;

public partial class FigureShopDbContext : DbContext
{
    public FigureShopDbContext()
    {
    }

    public FigureShopDbContext(DbContextOptions<FigureShopDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Branch> Branches { get; set; }
    public virtual DbSet<Category> Categories { get; set; }
    public virtual DbSet<Comment> Comments { get; set; }
    public virtual DbSet<Figure> Figures { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<OrderFigure> OrderFigures { get; set; }
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<ShoppingCart> ShoppingCarts { get; set; }
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Voucher> Vouchers { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // We'll let EF Core handle Branch and Category by default.
        // We only add code for *special* cases.

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => new { e.FigureId, e.UserId });
            
            entity.HasOne(d => d.Figure).WithMany(p => p.Comments).HasForeignKey(d => d.FigureId);
            entity.HasOne(d => d.User).WithMany(p => p.Comments).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Figure>(entity =>
        {
            entity.Property(e => e.ImgSrcJson).HasDefaultValue("[]");
            
            entity.Property(e => e.Name).HasMaxLength(255);
            
            entity.HasOne(d => d.Branch).WithMany(p => p.Figures)
                .HasForeignKey(d => d.BranchId)
                .OnDelete(DeleteBehavior.SetNull);

            entity.HasOne(d => d.Category).WithMany(p => p.Figures)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.SetNull);
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.PhoneNumber).HasMaxLength(20);
            
            entity.HasOne(d => d.User).WithMany(p => p.Orders).HasForeignKey(d => d.UserId);
            
            entity.HasOne(d => d.Voucher).WithMany(p => p.Orders)
                .HasForeignKey(d => d.VoucherId)
                .OnDelete(DeleteBehavior.Cascade);
        });

        modelBuilder.Entity<OrderFigure>(entity =>
        {
            entity.HasKey(e => new { e.FigureId, e.UserId });
            
            entity.HasOne(d => d.Figure).WithMany(p => p.OrderFigures).HasForeignKey(d => d.FigureId);
            entity.HasOne(d => d.Order).WithMany(p => p.OrderFigures).HasForeignKey(d => d.OrderId);
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Name);
            entity.Property(e => e.Name).HasMaxLength(50);
            
            entity.HasMany(d => d.Users).WithMany(p => p.RolesNames)
                .UsingEntity<Dictionary<string, object>>(
                    "UserRole",
                    r => r.HasOne<User>().WithMany().HasForeignKey("UserId"),
                    l => l.HasOne<Role>().WithMany().HasForeignKey("RolesName"),
                    j =>
                    {
                        j.HasKey("RolesName", "UserId");
                        j.ToTable("UserRole");
                        j.HasIndex(new[] { "UserId" }, "IX_UserRole_UserId");
                        j.IndexerProperty<string>("RolesName").HasMaxLength(50);
                    });
        });

        modelBuilder.Entity<ShoppingCart>(entity =>
        {
            entity.HasKey(e => new { e.FigureId, e.UserId });

            entity.HasOne(d => d.Figure).WithMany(p => p.ShoppingCarts).HasForeignKey(d => d.FigureId);
            entity.HasOne(d => d.User).WithMany(p => p.ShoppingCarts).HasForeignKey(d => d.UserId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}