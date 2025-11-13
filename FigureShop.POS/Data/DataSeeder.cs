// ReSharper disable LocalizableElement
using FigureShop.POS.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FigureShop.POS.Data
{
    public static class DataSeeder
    {
        public static void Initialize(FigureShopDbContext context)
        {
            // Check if the database is already seeded.
            if (context.Users.Any())
            {
                return; // Database is already seeded
            }

            try
            {
                // === 1. IDs ===
                var adminId = Guid.NewGuid();
                var staffId = Guid.NewGuid();
                var cust1Id = Guid.NewGuid(); // Ari
                var cust2Id = Guid.NewGuid(); // Test User
                var cust3Id = Guid.NewGuid(); // Nguyen Van A
                var cust4Id = Guid.NewGuid(); // Le Thi B
                var cust5Id = Guid.NewGuid(); // Khach vang lai
                var cust6Id = Guid.NewGuid();
                var cust7Id = Guid.NewGuid();// Banned user

                // === 2. Roles ===
                var roleAdmin = new Role { Name = "Admin" };
                var roleStaff = new Role { Name = "Staff" };
                var roleCustomer = new Role { Name = "Customer" };
                var roleManager = new Role { Name = "Manager" };
                context.Roles.AddRange(roleAdmin, roleStaff, roleCustomer, roleManager);
                
                // === 3. Users ===
                var userAdmin = new User
                {
                    Id = adminId, Email = "admin@figureshop.com", Password = "adminpass", Status = "Active",
                    FullName = "Admin Ari", PhoneNumber = "0900000001", Address = "Shop HQ",
                    CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId,
                    RolesNames = new List<Role> { roleAdmin }
                };
                var userStaff = new User
                {
                    Id = staffId, Email = "staff@figureshop.com", Password = "staffpass", Status = "Active",
                    FullName = "Staff Member", PhoneNumber = "0900000002", Address = "Shop Floor",
                    CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId,
                    RolesNames = new List<Role> { roleStaff }
                };
                var userCust1 = new User
                {
                    Id = cust1Id, Email = "ari@customer.com", Password = "aripass", Status = "Active",
                    FullName = "Ari (Customer)", PhoneNumber = "0912345678", Address = "123 Ba Dinh, Hanoi",
                    CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId,
                    RolesNames = new List<Role> { roleCustomer }
                };
                var userCust2 = new User
                {
                    Id = cust2Id, Email = null, Password = null, Status = "Active", // Guest user
                    FullName = "Nguyen Van A", PhoneNumber = "0987654321", Address = "456 Cau Giay, Hanoi",
                    CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId,
                    RolesNames = new List<Role> { roleCustomer }
                };
                var userCust3 = new User
                {
                    Id = cust3Id, Email = "lethib@email.com", Password = "123", Status = "Active",
                    FullName = "Le Thi B", PhoneNumber = "0933333333", Address = "789 Hoan Kiem, Hanoi",
                    CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId,
                    RolesNames = new List<Role> { roleCustomer }
                };
                var userCust4 = new User
                {
                    Id = cust4Id, Email = null, Password = null, Status = "Active",
                    FullName = "Khach Vang Lai", PhoneNumber = null, Address = "Tai quay",
                    CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId,
                    RolesNames = new List<Role> { roleCustomer }
                };
                var userCust5 = new User
                {
                    Id = cust5Id, Email = "banned@email.com", Password = "123", Status = "Banned",
                    FullName = "Banned User", PhoneNumber = "0944444444", Address = "Blacklist",
                    CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId,
                    RolesNames = new List<Role> { roleCustomer }
                };
                 var userCust6 = new User
                {
                    Id = cust6Id, Email = "staff2@figureshop.com", Password = "staffpass2", Status = "Active",
                    FullName = "Staff Member 2", PhoneNumber = "0900000003", Address = "Shop Floor",
                    CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId,
                    RolesNames = new List<Role> { roleStaff }
                };
                var userCust7 = new User
                {
                    Id = cust7Id, Email = "admin", Password = "admin", Status = "Active",
                    FullName = "Ari_2", PhoneNumber = null, Address = null,
                    CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId,
                    RolesNames = new List<Role> { roleAdmin }
                };
                context.Users.AddRange(userAdmin, userStaff, userCust1, userCust2, userCust3, userCust4, userCust5, userCust6, userCust7);

                // === 4. Branches ===
                var branchGSC = new Branch { Id = Guid.NewGuid(), Name = "Good Smile Company", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
                var branchBandai = new Branch { Id = Guid.NewGuid(), Name = "Bandai Spirits", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
                var branchKoto = new Branch { Id = Guid.NewGuid(), Name = "Kotobukiya", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
                var branchAniplex = new Branch { Id = Guid.NewGuid(), Name = "Aniplex", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
                var branchFREEing = new Branch { Id = Guid.NewGuid(), Name = "FREEing", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
                var branchAlter = new Branch { Id = Guid.NewGuid(), Name = "Alter", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
                var branchMax = new Branch { Id = Guid.NewGuid(), Name = "Max Factory", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
                context.Branches.AddRange(branchGSC, branchBandai, branchKoto, branchAniplex, branchFREEing, branchAlter, branchMax);

                // === 5. Categories ===
                var catNendo = new Category { Id = Guid.NewGuid(), Name = "Nendoroid", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
                var catFigma = new Category { Id = Guid.NewGuid(), Name = "Figma", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
                var catScale7 = new Category { Id = Guid.NewGuid(), Name = "1/7 Scale", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
                var catScale8 = new Category { Id = Guid.NewGuid(), Name = "1/8 Scale", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
                var catPlush = new Category { Id = Guid.NewGuid(), Name = "Plush", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
                var catPrize = new Category { Id = Guid.NewGuid(), Name = "Prize Figure", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
                var catModelKit = new Category { Id = Guid.NewGuid(), Name = "Model Kit", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
                var catPUP = new Category { Id = Guid.NewGuid(), Name = "Pop Up Parade", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId };
                context.Categories.AddRange(catNendo, catFigma, catScale7, catScale8, catPlush, catPrize, catModelKit, catPUP);

                // === 6. Figures (THE BIG LIST!) ===
                var figures = new List<Figure>
                {
                    new Figure { Id = Guid.NewGuid(), Branch = branchGSC, Category = catNendo, Price = 55.00, Quantity = 50, Description = "Nendoroid of Hatsune Miku, version 3.0!", Vote = 4.8, Name = "Nendoroid Hatsune Miku 3.0", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId },
                    new Figure { Id = Guid.NewGuid(), Branch = branchMax, Category = catFigma, Price = 99.00, Quantity = 20, SalePercent = 10, SaleFrom = DateTime.Now, SaleTo = DateTime.Now.AddDays(30), Description = "Figma of Guts (Berserker Armor) from Berserk.", Vote = 4.9, Name = "Figma Guts (Berserker Armor)", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId },
                    new Figure { Id = Guid.NewGuid(), Branch = branchKoto, Category = catScale7, Price = 180.00, Quantity = 15, Description = "1/7 Scale figure of Asuna in her Undine avatar from SAO.", Vote = 4.7, Name = "Asuna - Undine Ver.", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId },
                    new Figure { Id = Guid.NewGuid(), Branch = branchGSC, Category = catNendo, Price = 62.00, Quantity = 30, Description = "Nendoroid of Gojo Satoru from Jujutsu Kaisen.", Vote = 4.9, Name = "Nendoroid Gojo Satoru", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId },
                    new Figure { Id = Guid.NewGuid(), Branch = branchBandai, Category = catPrize, Price = 29.99, Quantity = 100, Description = "Prize figure of Anya Forger from Spy x Family.", Vote = 4.5, Name = "Figuarts Mini Anya Forger", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId },
                    new Figure { Id = Guid.NewGuid(), Branch = branchFREEing, Category = catScale8, Price = 220.00, Quantity = 10, Description = "1/8 Scale figure of Makima in a bunny suit.", Vote = 4.6, Name = "Makima: Bunny Ver.", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId },
                    new Figure { Id = Guid.NewGuid(), Branch = branchAniplex, Category = catScale8, Price = 199.99, Quantity = 5, SalePercent = 20, SaleFrom = DateTime.Now, SaleTo = DateTime.Now.AddDays(14), Description = "1/8 Scale Kyojuro Rengoku. Set your heart ablaze!", Vote = 5.0, Name = "Rengoku Kyojuro 1/8 Scale", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId, ImgSrcJson = @"Images\icon.png"},
                    new Figure { Id = Guid.NewGuid(), Branch = branchKoto, Category = catScale7, Price = 165.00, Quantity = 0, Description = "1/7 Scale figure of Echidna from Re:Zero. (Out of stock)", Vote = 4.7, Name = "Echidna - Tea Party Ver.", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId },
                    new Figure { Id = Guid.NewGuid(), Branch = branchAlter, Category = catScale7, Price = 210.00, Quantity = 12, Description = "1/7 Scale figure of Prinz Eugen from Azur Lane.", Vote = 4.8, Name = "Prinz Eugen (Final Lap Ver.)", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId },
                    new Figure { Id = Guid.NewGuid(), Branch = branchBandai, Category = catModelKit, Price = 45.00, Quantity = 40, Description = "Real Grade kit of the Hi-Nu Gundam.", Vote = 4.9, Name = "RG Hi-Nu Gundam", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId },
                    new Figure { Id = Guid.NewGuid(), Branch = branchGSC, Category = catPUP, Price = 39.99, Quantity = 60, Description = "Pop Up Parade figure of Eren Yeager (Attack Titan).", Vote = 4.6, Name = "PUP Eren Yeager: Attack Titan", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId },
                    new Figure { Id = Guid.NewGuid(), Branch = branchGSC, Category = catNendo, Price = 58.00, Quantity = 25, Description = "Nendoroid of Kirby (30th Anniversary).", Vote = 4.9, Name = "Nendoroid Kirby 30th", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId },
                    new Figure { Id = Guid.NewGuid(), Branch = branchMax, Category = catFigma, Price = 88.00, Quantity = 18, Description = "Figma of Ann Takamaki (Panther) from Persona 5.", Vote = 4.7, Name = "Figma Ann Takamaki", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId },
                    new Figure { Id = Guid.NewGuid(), Branch = branchAlter, Category = catScale7, Price = 190.00, Quantity = 8, Description = "1/7 Scale figure of Asuka Langley (Jersey Ver.)", Vote = 4.8, Name = "Asuka Langley Shikinami", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId },
                    new Figure { Id = Guid.NewGuid(), Branch = branchKoto, Category = catModelKit, Price = 60.00, Quantity = 30, Description = "HMM kit of the Liger Zero from Zoids.", Vote = 4.9, Name = "HMM Liger Zero", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId },
                    new Figure { Id = Guid.NewGuid(), Branch = branchGSC, Category = catNendo, Price = 60.00, Quantity = 33, Description = "Nendoroid of Lum from Urusei Yatsura.", Vote = 4.7, Name = "Nendoroid Lum", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId },
                    new Figure { Id = Guid.NewGuid(), Branch = branchGSC, Category = catPUP, Price = 39.99, Quantity = 0, Description = "Pop Up Parade figure of Guts (Berserker Armor). (Out of stock)", Vote = 4.8, Name = "PUP Guts (Berserker Armor)", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId },
                    new Figure { Id = Guid.NewGuid(), Branch = branchBandai, Category = catModelKit, Price = 25.00, Quantity = 70, Description = "High Grade kit of the Aerial Gundam.", Vote = 4.6, Name = "HG Gundam Aerial", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId },
                    new Figure { Id = Guid.NewGuid(), Branch = branchAniplex, Category = catScale7, Price = 250.00, Quantity = 10, Description = "1/7 Scale figure of Mai Sakurajima.", Vote = 4.9, Name = "Mai Sakurajima (Rascal Does Not Dream)", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId },
                    new Figure { Id = Guid.NewGuid(), Branch = branchFREEing, Category = catScale7, Price = 280.00, Quantity = 5, Description = "1/7 Scale figure of Zero Two (Bunny Ver.)", Vote = 4.8, Name = "Zero Two: Bunny Ver.", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId }
                };
                context.Figures.AddRange(figures);

                // === 7. Vouchers ===
                var voucher10 = new Voucher
                {
                    Id = Guid.NewGuid(), MinPriceCanUse = 50.00, MaxPriceCanDiscount = 20.00, Description = "10% off orders over $50 (Max $20)",
                    Quantity = 100, IsActive = true, SalePercent = 10.0, UsedFrom = DateTime.Now, UsedTo = DateTime.Now.AddMonths(3),
                    FiguresAvailable = "[]", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId
                };
                var voucherWelcome = new Voucher
                {
                    Id = Guid.NewGuid(), MinPriceCanUse = 0, MaxPriceCanDiscount = 10.00, Description = "Welcome! $10 off first order",
                    Quantity = 500, IsActive = true, SalePercent = 0, UsedFrom = DateTime.Now, UsedTo = DateTime.Now.AddMonths(1),
                    FiguresAvailable = "[]", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId
                };
                var voucherExpired = new Voucher
                {
                    Id = Guid.NewGuid(), MinPriceCanUse = 100.00, MaxPriceCanDiscount = 50.00, Description = "Expired $50 Holiday Voucher",
                    Quantity = 0, IsActive = false, SalePercent = 0, UsedFrom = DateTime.Now.AddYears(-1), UsedTo = DateTime.Now.AddMonths(-11),
                    FiguresAvailable = "[]", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = adminId, UpdatedBy = adminId
                };
                context.Vouchers.AddRange(voucher10, voucherWelcome, voucherExpired);

                // === 8. Orders ===
                // Order 1: Ari buys Miku and Asuna (2 items)
                var order1 = new Order
                {
                    Id = Guid.NewGuid(), UserId = cust1Id, VoucherId = null, Status = "Completed", TotalPrice = 235.00, PaidPrice = 235.00,
                    PhoneNumber = "0912345678", Address = "123 Ba Dinh, Hanoi", CreatedAt = DateTime.Now.AddDays(-10),
                    CreatedBy = staffId, UpdatedAt = DateTime.Now.AddDays(-10), UpdatedBy = staffId
                };
                // Order 2: Nguyen Van A buys Gojo (1 item)
                var order2 = new Order
                {
                    Id = Guid.NewGuid(), UserId = cust2Id, VoucherId = null, Status = "Shipped", TotalPrice = 62.00, PaidPrice = 62.00,
                    PhoneNumber = "0987654321", Address = "456 Cau Giay, Hanoi", CreatedAt = DateTime.Now.AddDays(-5),
                    CreatedBy = staffId, UpdatedAt = DateTime.Now.AddDays(-5), UpdatedBy = staffId
                };
                // Order 3: Le Thi B buys Rengoku (on sale) and a RG Gundam (2 items)
                var priceRengoku = 199.99 * (1 - 0.20); // 20% off
                var order3 = new Order
                {
                    Id = Guid.NewGuid(), UserId = cust3Id, VoucherId = null, Status = "Processing", TotalPrice = priceRengoku + 45.00, PaidPrice = 0,
                    PhoneNumber = "0933333333", Address = "789 Hoan Kiem, Hanoi", CreatedAt = DateTime.Now.AddDays(-1),
                    CreatedBy = staffId, UpdatedAt = DateTime.Now.AddDays(-1), UpdatedBy = staffId
                };
                // Order 4: Khach Vang Lai buys an Anya prize fig (1 item)
                var order4 = new Order
                {
                    Id = Guid.NewGuid(), UserId = cust4Id, VoucherId = null, Status = "Completed", TotalPrice = 29.99, PaidPrice = 29.99,
                    PhoneNumber = "N/A", Address = "Tai quay", CreatedAt = DateTime.Now,
                    CreatedBy = staffId, UpdatedAt = DateTime.Now, UpdatedBy = staffId
                };
                context.Orders.AddRange(order1, order2, order3, order4);

                // === 9. OrderFigures ===
                context.OrderFigures.AddRange(
                    // Order 1
                    new OrderFigure { Id = Guid.NewGuid(), OrderId = order1.Id, FigureId = figures[0].Id, UserId = cust1Id, Quantity = 1, Price = 55.00, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = staffId, UpdatedBy = staffId },
                    new OrderFigure { Id = Guid.NewGuid(), OrderId = order1.Id, FigureId = figures[2].Id, UserId = cust1Id, Quantity = 1, Price = 180.00, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = staffId, UpdatedBy = staffId },
                    // Order 2
                    new OrderFigure { Id = Guid.NewGuid(), OrderId = order2.Id, FigureId = figures[3].Id, UserId = cust2Id, Quantity = 1, Price = 62.00, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = staffId, UpdatedBy = staffId },
                    // Order 3
                    new OrderFigure { Id = Guid.NewGuid(), OrderId = order3.Id, FigureId = figures[6].Id, UserId = cust3Id, Quantity = 1, Price = priceRengoku, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = staffId, UpdatedBy = staffId },
                    new OrderFigure { Id = Guid.NewGuid(), OrderId = order3.Id, FigureId = figures[9].Id, UserId = cust3Id, Quantity = 1, Price = 45.00, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = staffId, UpdatedBy = staffId },
                    // Order 4
                    new OrderFigure { Id = Guid.NewGuid(), OrderId = order4.Id, FigureId = figures[4].Id, UserId = cust4Id, Quantity = 1, Price = 29.99, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = staffId, UpdatedBy = staffId }
                );
                
                // === 10. Comments ===
                context.Comments.AddRange(
                    new Comment { Id = Guid.NewGuid(), UserId = cust1Id, FigureId = figures[0].Id, Vote = 5, Content = "She is so cute! Love the accessories.", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = cust1Id, UpdatedBy = cust1Id },
                    new Comment { Id = Guid.NewGuid(), UserId = cust1Id, FigureId = figures[2].Id, Vote = 5, Content = "Absolutely gorgeous figure. Kotobukiya never disappoints!", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = cust1Id, UpdatedBy = cust1Id },
                    new Comment { Id = Guid.NewGuid(), UserId = cust2Id, FigureId = figures[1].Id, Vote = 1, Content = "Box arrived damaged. Not happy.", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = cust2Id, UpdatedBy = cust2Id },
                    new Comment { Id = Guid.NewGuid(), UserId = cust3Id, FigureId = figures[9].Id, Vote = 5, Content = "This RG kit is a masterpiece.", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now, CreatedBy = cust3Id, UpdatedBy = cust3Id }
                );

                // === 11. ShoppingCarts ===
                context.ShoppingCarts.AddRange(
                    // Ari has the out-of-stock Echidna in their cart
                    new ShoppingCart { UserId = cust1Id, FigureId = figures[7].Id, Quantity = 1 },
                    // Le Thi B has the Asuka figure
                    new ShoppingCart { UserId = cust3Id, FigureId = figures[13].Id, Quantity = 2 }
                );
                
                // === 12. Save Everything! ===
                context.SaveChanges();
                
                Console.WriteLine("Database has been successfully seeded with a LARGE amount of mock data!");
            }
            catch (Exception ex)
            {
                // This is super helpful if something goes wrong
                Console.WriteLine($"An error occurred while seeding the database: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
            }
        }
    }
}