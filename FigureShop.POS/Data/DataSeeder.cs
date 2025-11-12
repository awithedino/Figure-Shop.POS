using FigureShop.POS.Data.Models; // Make sure this matches your models path
using Microsoft.EntityFrameworkCore;

namespace FigureShop.POS.Data;

public static class DataSeeder
{
    public static void Initialize(FigureShopDbContext context)
    {
        if (context.Users.Any())
        {
            return;
        }

        try
        {
            // === Users & Roles ===
            var adminId = Guid.NewGuid();
            var staffId = Guid.NewGuid();
            var cust1Id = Guid.NewGuid();
            var cust2Id = Guid.NewGuid();

            var roleAdmin = new Role { Name = "Admin" };
            var roleStaff = new Role { Name = "Staff" };
            var roleCustomer = new Role { Name = "Customer" };
            
            context.Roles.AddRange(roleAdmin, roleStaff, roleCustomer);

            var userAdmin = new User
            {
                Id = adminId, Email = "admin@figureshop.com", Password = "adminpass", Status = "Active",
                CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId,
                RolesNames = new List<Role> { roleAdmin }
            };
            var userStaff = new User
            {
                Id = staffId, Email = "staff@figureshop.com", Password = "staffpass", Status = "Active",
                CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId,
                RolesNames = new List<Role> { roleStaff }
            };
            var userCust1 = new User
            {
                Id = cust1Id, Email = "ari@customer.com", Password = "aripass", Status = "Active",
                CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId,
                RolesNames = new List<Role> { roleCustomer }
            };
            var userCust2 = new User
            {
                Id = cust2Id, Email = "testuser@customer.com", Password = "testpass", Status = "Banned",
                CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId,
                RolesNames = new List<Role> { roleCustomer }
            };
            
            context.Users.AddRange(userAdmin, userStaff, userCust1, userCust2);

            // === Branches & Categories ===
            var branchGSC = new Branch { Id = Guid.NewGuid(), Name = "Good Smile Company", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
            var branchBandai = new Branch { Id = Guid.NewGuid(), Name = "Bandai Spirits", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
            var branchKoto = new Branch { Id = Guid.NewGuid(), Name = "Kotobukiya", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
            var branchAniplex = new Branch { Id = Guid.NewGuid(), Name = "Aniplex", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
            
            context.Branches.AddRange(branchGSC, branchBandai, branchKoto, branchAniplex);
            
            var catNendo = new Category { Id = Guid.NewGuid(), Name = "Nendoroid", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
            var catFigma = new Category { Id = Guid.NewGuid(), Name = "Figma", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
            var catScale7 = new Category { Id = Guid.NewGuid(), Name = "1/7 Scale", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
            var catPrize = new Category { Id = Guid.NewGuid(), Name = "Prize Figure", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };

            context.Categories.AddRange(catNendo, catFigma, catScale7, catPrize);
            
            // === Figures ===
            var figMiku = new Figure
            {
                Id = Guid.NewGuid(), Branch = branchGSC, Category = catNendo, Price = 55.00, Quantity = 50,
                Description = "Nendoroid of Hatsune Miku, version 3.0!", Vote = 4.8, Name = "Nendoroid Hatsune Miku 3.0",
                CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId
            };
            var figGuts = new Figure
            {
                Id = Guid.NewGuid(), Branch = branchGSC, Category = catFigma, Price = 99.00, Quantity = 20,
                SalePercent = 10, SaleFrom = DateTime.Now, SaleTo = DateTime.Now.AddDays(30),
                Description = "Figma of Guts (Berserker Armor) from Berserk.", Vote = 4.9, Name = "Figma Guts (Berserker Armor)",
                CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId
            };
            var figAsuna = new Figure
            {
                Id = Guid.NewGuid(), Branch = branchKoto, Category = catScale7, Price = 180.00, Quantity = 15,
                Description = "1/7 Scale figure of Asuna in her Undine avatar from SAO.", Vote = 4.7, Name = "Asuna - Undine Ver.",
                CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId
            };
            var figAnya = new Figure
            {
                Id = Guid.NewGuid(), Branch = branchBandai, Category = catPrize, Price = 29.99, Quantity = 100,
                Description = "Prize figure of Anya Forger from Spy x Family.", Vote = 4.5, Name = "Figuarts Mini Anya Forger",
                CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId
            };
            
            context.Figures.AddRange(figMiku, figGuts, figAsuna, figAnya);
            
            // 3. Save everything to the database!
            context.SaveChanges();
            
            Console.WriteLine("Database has been successfully seeded with mock data!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while seeding the database: {ex.Message}");
        }
    }
}