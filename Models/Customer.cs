using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace firstTry.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        [JsonIgnore]
        public List<Order> Orders { get; set; } //om inlogg finns kan samma kund göra flera ordrar.
    }
}