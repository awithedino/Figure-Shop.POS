using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FigureShop.POS.Models;

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

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=FigureShopDb;User=sa;Password=P@ssw0rd123;Encrypt=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Branch>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Comment>(entity =>
        {
            entity.HasKey(e => new { e.FigureId, e.UserId });

            entity.HasIndex(e => e.UserId, "IX_Comments_UserId");

            entity.HasOne(d => d.Figure).WithMany(p => p.Comments).HasForeignKey(d => d.FigureId);

            entity.HasOne(d => d.User).WithMany(p => p.Comments).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Figure>(entity =>
        {
            entity.HasIndex(e => e.BranchId, "IX_Figures_BranchId");

            entity.HasIndex(e => e.CategoryId, "IX_Figures_CategoryId");

            entity.Property(e => e.Id).ValueGeneratedNever();
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
            entity.HasIndex(e => e.UserId, "IX_Orders_UserId");

            entity.HasIndex(e => e.VoucherId, "IX_Orders_VoucherId");

            entity.Property(e => e.Id).ValueGeneratedNever();
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

            entity.HasIndex(e => e.OrderId, "IX_OrderFigures_OrderId");

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

            entity.HasIndex(e => e.UserId, "IX_ShoppingCarts_UserId");

            entity.HasOne(d => d.Figure).WithMany(p => p.ShoppingCarts).HasForeignKey(d => d.FigureId);

            entity.HasOne(d => d.User).WithMany(p => p.ShoppingCarts).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Voucher>(entity =>
        {
            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
