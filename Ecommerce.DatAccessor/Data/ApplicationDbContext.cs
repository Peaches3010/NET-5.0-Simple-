using Ecommerce.DataAccessor.Entities;
using Ecommerce.DatAccessor.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DatAccessor.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Category>(entity =>
            {
                entity.ToTable(name: "Category");
            });

            builder.Entity<Product>(entity =>
            {
                entity.ToTable(name: "Product");
            });

            builder.Entity<OrderItem>(entity =>
            {
                entity.ToTable(name: "OrderItem");
            });

            builder.Entity<OrderAddress>(entity =>
            {
                entity.ToTable(name: "OrderAdress");
            });

            builder.Entity<OrderHistory>(entity =>
            {
                entity.ToTable(name: "OrderHistory")
                .HasOne(entity => entity.CreatedBy)
                .WithMany()
                .HasForeignKey(entity => entity.CreatorId);
            });

            builder.Entity<Order>(entity =>
            {
                entity.ToTable(name: "Order")
                .HasOne(entity => entity.ShippingAddress)
                .WithMany().HasForeignKey(entity => entity.ShippingAddressId);
            });

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrdeItems { get; set; }
        public DbSet<OrderAddress> OrderAddresses { get; set; }

    }
}
