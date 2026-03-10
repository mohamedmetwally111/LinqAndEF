using LinkAndEF04.Configration_classes;
using LinkAndEF04.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinkAndEF04.DbContect
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=e-commerce;Trusted_Connection=True;TrustServerCertificate=True;");
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Category_Configuration());
            modelBuilder.ApplyConfiguration(new Product_Configuration());
            modelBuilder.ApplyConfiguration(new Order_configuration());
            modelBuilder.ApplyConfiguration(new Customer_Configuration());
            modelBuilder.ApplyConfiguration(new OrderDetails_Configuration());

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
