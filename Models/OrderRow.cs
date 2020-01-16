namespace firstTry.Models
{
    public class OrderRow
    {
        public int Id { get; set; }
        public int SurfBoardId { get; set; }
        public Surfboard Surfboards { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}