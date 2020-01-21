using System.Text.Json.Serialization;

namespace firstTry.Models
{
    public class OrderRow
    {
        public int Id { get; set; }
        public int SurfBoardId { get; set; }
        [JsonIgnore]
        public Surfboard Surfboard { get; set; }
        public int ColorId { get; set; }
        [JsonIgnore]
        public Color Color { get; set; }
        // public int OrderId { get; set; }
        // [JsonIgnore]
        // public Order Order { get; set; }
    }
}