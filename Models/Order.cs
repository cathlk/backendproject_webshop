using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace firstTry.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<OrderRow> OrderRows { get; set; }
    }
}