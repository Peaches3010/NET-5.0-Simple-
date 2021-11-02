using Ecommerce.DatAccessor.Data;
using Ecommerce.DatAccessor.Entities;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DataAccessor.Data
{
    public class ApplicationDbContextSeed
    {
        public async Task SeedAsync(ApplicationDbContext context, ILogger<ApplicationDbContextSeed> logger)
        {
            if (!context.Categories.Any())
            {
                context.Categories.AddRange
                    (
                    new Category
                    {
                        Id = Guid.Parse("44869777-75f0-4e3f-b5b2-d9f793acd7c0"),
                        Name = "MacBook",
                        CreatedDate = DateTime.Now,
                    },
                    new Category
                    {
                        Id = Guid.Parse("54f7166b-fcb1-4f52-8d47-596a6761a1af"),
                        Name = "Dell",
                        CreatedDate = DateTime.Now,
                    },
                    new Category
                    {
                        Id = Guid.Parse("8dc9bdd7-29cd-4cfb-ab01-8fffc2e3a996"),
                        Name = "Lenovo",
                        CreatedDate = DateTime.Now,
                    }
                    );
                await context.SaveChangesAsync();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange
                    (
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Macbook M1 14 inch",
                        Desc = "abc",
                        Price = 40000000,
                        IsFeatured = false,
                        CategoryId = Guid.Parse("44869777-75f0-4e3f-b5b2-d9f793acd7c0"),
                        CreatedDate = DateTime.Now
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Macbook M1 16 inch",
                        Desc = "abc",
                        Price = 70000000,
                        IsFeatured = false,
                        CategoryId = Guid.Parse("44869777-75f0-4e3f-b5b2-d9f793acd7c0"),
                        CreatedDate = DateTime.Now
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Macbook Pro 2019 16 inch",
                        Desc = "abc",
                        Price = 45000000,
                        IsFeatured = false,
                        CategoryId = Guid.Parse("44869777-75f0-4e3f-b5b2-d9f793acd7c0"),
                        CreatedDate = DateTime.Now
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Macbook Pro 2018 16 inch",
                        Desc = "abc",
                        Price = 37000000,
                        IsFeatured = false,
                        CategoryId = Guid.Parse("44869777-75f0-4e3f-b5b2-d9f793acd7c0"),
                        CreatedDate = DateTime.Now
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Dell XPS 9500",
                        Desc = "abc",
                        Price = 40000000,
                        IsFeatured = false,
                        CategoryId = Guid.Parse("54f7166b-fcb1-4f52-8d47-596a6761a1af"),
                        CreatedDate = DateTime.Now
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Dell XPS 9300",
                        Desc = "abc",
                        Price = 30000000,
                        IsFeatured = false,
                        CategoryId = Guid.Parse("54f7166b-fcb1-4f52-8d47-596a6761a1af"),
                        CreatedDate = DateTime.Now
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Dell XPS 9310",
                        Desc = "abc",
                        Price = 37000000,
                        IsFeatured = false,
                        CategoryId = Guid.Parse("54f7166b-fcb1-4f52-8d47-596a6761a1af"),
                        CreatedDate = DateTime.Now
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Dell XPS 9510",
                        Desc = "abc",
                        Price = 57000000,
                        IsFeatured = false,
                        CategoryId = Guid.Parse("54f7166b-fcb1-4f52-8d47-596a6761a1af"),
                        CreatedDate = DateTime.Now
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Lenovo ThinkPad X1 Carbon Gen 7",
                        Desc = "abc",
                        Price = 27000000,
                        IsFeatured = false,
                        CategoryId = Guid.Parse("8dc9bdd7-29cd-4cfb-ab01-8fffc2e3a996"),
                        CreatedDate = DateTime.Now
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Lenovo ThinkPad X1 Carbon Gen 8",
                        Desc = "abc",
                        Price = 37000000,
                        IsFeatured = false,
                        CategoryId = Guid.Parse("8dc9bdd7-29cd-4cfb-ab01-8fffc2e3a996"),
                        CreatedDate = DateTime.Now
                    },
                    new Product
                    {
                        Id = Guid.NewGuid(),
                        Name = "Lenovo ThinkPad X1 Carbon Gen 9",
                        Desc = "abc",
                        Price = 47000000,
                        IsFeatured = false,
                        CategoryId = Guid.Parse("8dc9bdd7-29cd-4cfb-ab01-8fffc2e3a996"),
                        CreatedDate = DateTime.Now
                    }
                    );
                await context.SaveChangesAsync();
            }
        }
    }
}
