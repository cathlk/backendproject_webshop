using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace firstTry.Models
{
    public class OrderRow
    {
        public int Id { get; set; }
        public int SurfBoardId { get; set; }
        public Surfboard Surfboard { get; set; }
        public int ColorId { get; set; }
        public Color Color { get; set; }
        public int OrderId { get; set; }
        [JsonIgnore]
        public Order Order { get; set; }
    }
}