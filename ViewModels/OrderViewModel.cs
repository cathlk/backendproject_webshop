
using System.Collections.Generic;

namespace firstTry.Models
{
    public class OrderViewModel
    {
        public List<ProductViewModel> Cart { get; set; }
        public CustomerViewModel Customer { get; set; }
    }
}