using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace firstTry.Models
{
    public class Surfboard
    {
        public int Id { get; set; }
        public string Shape { get; set; } //gun, fish, long, short; 4 st

        // public int Volume { get; set; }
        // public int Price { get; set; }
        public List<Color> Colors { get; set; }
        public List<OrderRow> OrderRows { get; set; }
    }
}