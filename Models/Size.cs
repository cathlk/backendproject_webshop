using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace firstTry.Models
{
    public class Size
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [JsonIgnore]
        public List<OrderRow> OrderRows { get; set; }
    }
}