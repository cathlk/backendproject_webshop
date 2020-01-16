using System.Collections.Generic;

namespace firstTry.Models
{
    public class Surfboard
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Price { get; set; }
        public List<OrderRow> OrderRows { get; set; }
    }
}