using System.Collections.Generic;
using System.Linq;
using firstTry.Contexts;
using firstTry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace firstTry.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<List<Order>> Get()
        {
            using (SurfboardContext context = new SurfboardContext())
            {
                List<Customer> Customers = context.Customers.ToList();
                return Ok(Customers);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<List<Order>> Get(int id)
        {
            using (SurfboardContext context = new SurfboardContext())
            {
                Customer Customer = context.Customers.First(c => c.Id == id);
                return Ok(Customer);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Customer newCustomer)
        {
            using (SurfboardContext context = new SurfboardContext())
            {
                context.Customers.Add(newCustomer);
                context.SaveChanges();
            }
            return Created("/customers", newCustomer);

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using (SurfboardContext context = new SurfboardContext())
            {
                Customer deleteCustomer = context.Customers.First(c => c.Id == id);
                context.Customers.Remove(deleteCustomer);
                context.SaveChanges();
            }
            return Ok();
        }
    }
}
