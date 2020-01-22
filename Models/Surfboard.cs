using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace firstTry.Models
{
    public class Surfboard
    {
        public int Id { get; set; }
        public string Shape { get; set; }
        public int Price { get; set; }
        [JsonIgnore]
        public List<OrderRow> OrderRows { get; set; }
    }
}