using firstTry.Models;
using Microsoft.EntityFrameworkCore;

namespace firstTry.Contexts
{

    public class SurfboardContext : DbContext
    {
        public DbSet<Surfboard> Surfboards { get; set; } // Tabellen Surfboards
        public DbSet<Order> Orders { get; set; } // Tabellen Orders
        public DbSet<OrderRow> OrderRows { get; set; } // Tabellen OrderRows
        public DbSet<Customer> Customers { get; set; } // Tabellen Customers 

        //För att berätta för Entity Framework var någonstans en databas skall skapas upp samt vilken teknik som skall användas använder vi metoden OnConfiguring:
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=surfboards.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Surfboard  
            modelBuilder.Entity<Surfboard>().HasData(new Surfboard
            {
                Id = 1,
                Name = "Fish",
                Color = "Green",
                Price = 2555,
            });
            modelBuilder.Entity<Surfboard>().HasData(new Surfboard
            {
                Id = 2,
                Name = "Longboard",
                Color = "Black",
                Price = 5555,
            });
            modelBuilder.Entity<Surfboard>().HasData(new Surfboard
            {
                Id = 3,
                Name = "Shortboard",
                Color = "Pink",
                Price = 5155,
            });
        }
    }
}