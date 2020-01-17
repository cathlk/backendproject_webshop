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
        public DbSet<Color> Colors { get; set; } //Tabellen Colors

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

            });
            modelBuilder.Entity<Surfboard>().HasData(new Surfboard
            {
                Id = 2,
                Shape = "Fish"
            });
            modelBuilder.Entity<Surfboard>().HasData(new Surfboard
            {
                Id = 3,
                Shape = "Shortboard"

            });
            modelBuilder.Entity<Surfboard>().HasData(new Surfboard
            {
                Id = 4,
                Shape = "Longboard"

            });

            //Colors
            modelBuilder.Entity<Color>().HasData(new Color
            {
                Id = 1,
                Name = "Pink",
                SurfboardId = 3
            });
            modelBuilder.Entity<Color>().HasData(new Color
            {
                Id = 2,
                Name = "Grey",
                SurfboardId = 2
            });
            modelBuilder.Entity<Color>().HasData(new Color
            {
                Id = 3,
                Name = "Black",
                SurfboardId = 2

            });

        }
    }
}