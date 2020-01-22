using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace firstTry.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<OrderRow> OrderRows { get; set; }
    }
}