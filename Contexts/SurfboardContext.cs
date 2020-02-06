using System;
using firstTry.Models;
using Microsoft.EntityFrameworkCore;

namespace firstTry.Contexts
{

    public class SurfboardContext : DbContext
    {
        public DbSet<Surfboard> Surfboards { get; set; } // Tabellen Surfboards
        public DbSet<Size> Sizes { get; set; } //Tabellen Sizes
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
                Shape = "Longboard",
                ImageUrl = "https://shopcdn2.textalk.se/shop/26254/art54/h8795/22218795-origpic-567940.jpg?max-width=549&max-height=549&quality=85",
                Description = "Denna brädan handlar om glid och flow med möjlighet för surfaren att vandra på brädan för maximal “nose riding time”. Av denna anledning är denna brädan lång, bredd och otroligt stabil. Om du är på jakt efter en riktigt rolig longboard att surfa down the line med så är Retro ditt val.",
                Price = 11403

            });
            modelBuilder.Entity<Surfboard>().HasData(new Surfboard
            {
                Id = 2,
                Shape = "Hybrid",
                ImageUrl = "https://shopcdn2.textalk.se/shop/26254/art54/h7693/38987693-origpic-98a47a.jpg?max-width=549&max-height=549&quality=85",
                Description = "En shortboard med longboard outline i framdelen! Fånga vågor är enkelt med denna bräda och den flatta rockern ger dig bästa glid. Bottenkurvan med pintail (samt subtil rocker vid tailen) ser till att du behåller full kontroll och manövrerbarhet. Inte nog med detta, Lovechild erbjuder dessutom 3 olika fin set up möjligheter. Single-fin, 2+1 eller quad!",
                Price = 2222

            });
            modelBuilder.Entity<Surfboard>().HasData(new Surfboard
            {
                Id = 3,
                Shape = "Fish",
                ImageUrl = "https://shopcdn2.textalk.se/shop/26254/art54/h4090/156144090-origpic-f52a2b.jpg?max-width=549&max-height=549&quality=85",
                Description = "Modern har blandat inslag av retrofish-shape från 70-talet tillsammans med en modern bottenstruktur samt med en quad-setup för att göra denna bräda till det optimala valet i små till medelstora vågor. Flow, smoothness och pure fun kännertecknar denna bräda.",
                Price = 4325
            });



            //Sizes
            modelBuilder.Entity<Size>().HasData(new Size
            {
                Id = 1,
                Name = "5'6",
            });
            modelBuilder.Entity<Size>().HasData(new Size
            {
                Id = 2,
                Name = "6'0",
            });
            modelBuilder.Entity<Size>().HasData(new Size
            {
                Id = 3,
                Name = "7'0",
            });
            modelBuilder.Entity<Size>().HasData(new Size
            {
                Id = 4,
                Name = "7'6",
            });
            modelBuilder.Entity<Size>().HasData(new Size
            {
                Id = 5,
                Name = "9'1",
            });
            modelBuilder.Entity<Size>().HasData(new Size
            {
                Id = 6,
                Name = "9'6",
            });


            // OrderRows
            modelBuilder.Entity<OrderRow>().HasData(new OrderRow
            {
                Id = 1,
                SurfBoardId = 2,
                SizeId = 1,
                OrderId = 1
            });
            modelBuilder.Entity<OrderRow>().HasData(new OrderRow
            {
                Id = 2,
                SurfBoardId = 2,
                SizeId = 2,
                OrderId = 1
            });
            modelBuilder.Entity<OrderRow>().HasData(new OrderRow
            {
                Id = 3,
                SurfBoardId = 3,
                SizeId = 3,
                OrderId = 1
            });
            modelBuilder.Entity<OrderRow>().HasData(new OrderRow
            {
                Id = 4,
                SurfBoardId = 1,
                SizeId = 5,
                OrderId = 2
            });
            modelBuilder.Entity<OrderRow>().HasData(new OrderRow
            {
                Id = 5,
                SurfBoardId = 3,
                SizeId = 4,
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