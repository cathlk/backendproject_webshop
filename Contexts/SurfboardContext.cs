using System;
using firstTry.Models;
using Microsoft.EntityFrameworkCore;

namespace firstTry.Contexts
{

    public class SurfboardContext : DbContext
    {
        public DbSet<Surfboard> Surfboards { get; set; } // Tabellen Surfboards
        public DbSet<Color> Colors { get; set; } //Tabellen Colors
        public DbSet<OrderRow> OrderRows { get; set; } // Tabellen OrderRows
        public DbSet<Order> Orders { get; set; } // Tabellen Orders
        public DbSet<Customer> Customers { get; set; } // Tabellen Customers 

        //För att berätta för Entity Framework var någonstans en databas skall skapas upp samt vilken teknik som skall användas använder vi metoden OnConfiguring:
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=surfboards.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Surfboards
            modelBuilder.Entity<Surfboard>().HasData(new Surfboard
            {
                Id = 1,
                Shape = "Gun",
                Price = 2345

            });
            modelBuilder.Entity<Surfboard>().HasData(new Surfboard
            {
                Id = 2,
                Shape = "Fish",
                Price = 4325
            });
            modelBuilder.Entity<Surfboard>().HasData(new Surfboard
            {
                Id = 3,
                Shape = "Shortboard",
                Price = 2222

            });
            modelBuilder.Entity<Surfboard>().HasData(new Surfboard
            {
                Id = 4,
                Shape = "Longboard",
                Price = 11403

            });


            //Colors
            modelBuilder.Entity<Color>().HasData(new Color
            {
                Id = 1,
                Name = "Pink",
            });
            modelBuilder.Entity<Color>().HasData(new Color
            {
                Id = 2,
                Name = "Grey",
            });
            modelBuilder.Entity<Color>().HasData(new Color
            {
                Id = 3,
                Name = "Black",
            });


            // OrderRows
            modelBuilder.Entity<OrderRow>().HasData(new OrderRow
            {
                Id = 1,
                SurfBoardId = 2,
                ColorId = 1,
                OrderId = 1
            });
            modelBuilder.Entity<OrderRow>().HasData(new OrderRow
            {
                Id = 2,
                SurfBoardId = 2,
                ColorId = 3,
                OrderId = 1
            });
            modelBuilder.Entity<OrderRow>().HasData(new OrderRow
            {
                Id = 3,
                SurfBoardId = 3,
                ColorId = 1,
                OrderId = 1
            });
            modelBuilder.Entity<OrderRow>().HasData(new OrderRow
            {
                Id = 4,
                SurfBoardId = 1,
                ColorId = 2,
                OrderId = 2
            });
            modelBuilder.Entity<OrderRow>().HasData(new OrderRow
            {
                Id = 5,
                SurfBoardId = 3,
                ColorId = 3,
                OrderId = 3
            });


            //Orders
            modelBuilder.Entity<Order>().HasData(new Order
            {
                Id = 1,
                OrderDate = DateTime.Now.AddDays(-20),
                CustomerId = 2,
            });
            modelBuilder.Entity<Order>().HasData(new Order
            {
                Id = 2,
                OrderDate = DateTime.Now.AddDays(-10),
                CustomerId = 1,
            });
            modelBuilder.Entity<Order>().HasData(new Order
            {
                Id = 3,
                OrderDate = DateTime.Now.AddDays(-4),
                CustomerId = 3,
            });


            //Customers
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 1,
                FirstName = "Tyler",
                LastName = "Wright",
                Address = "Bells Beach, Victoria"
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 2,
                FirstName = "Silvana",
                LastName = "Lima",
                Address = "Saquarema, Rio"
            });
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                Id = 3,
                FirstName = "Mason",
                LastName = "Ho",
                Address = "Honolua Bay, Maui"
            });






        }
    }
}