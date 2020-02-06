using System;
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
    public class OrderController : ControllerBase
    {
        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult<List<Order>> Get()
        {
            using (SurfboardContext context = new SurfboardContext())
            {
                List<Order> Orders = context.Orders
                    .Include(c => c.Customer)
                    .Include(or => or.OrderRows)
                        .ThenInclude(or => or.Surfboard)
                    .Include(or => or.OrderRows)
                        .ThenInclude(or => or.Size)
                    .ToList();
                return Ok(Orders);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<List<Order>> Get(int id)
        {
            using (SurfboardContext context = new SurfboardContext())
            {
                Order Order = context.Orders
                    .Include(c => c.Customer)
                    .Include(or => or.OrderRows)
                        .ThenInclude(or => or.Surfboard)
                    .Include(or => or.OrderRows)
                        .ThenInclude(or => or.Size)
                    .First(o => o.Id == id);
                return Ok(Order);
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] OrderViewModel newOrder)
        {
            using (SurfboardContext context = new SurfboardContext())
            {
                Customer c = new Customer();
                c.Address = newOrder.Customer.Address;
                c.FirstName = newOrder.Customer.FirstName;
                c.LastName = newOrder.Customer.LastName;

                context.Customers.Add(c);
                context.SaveChanges();

                Order o = new Order();
                o.OrderDate = DateTime.Now;
                o.CustomerId = c.Id;
                context.Orders.Add(o);
                context.SaveChanges();

                // Skapa orderrader!!!!
                foreach (var item in newOrder.Cart)
                {
                    OrderRow or = new OrderRow();
                    or.OrderId = o.Id;
                    or.SurfBoardId = item.Id;
                    or.Price = item.Price;
                    or.SizeId = item.SizeId;
                    context.OrderRows.Add(or);
                    context.SaveChanges();
                }
                
                return Created("/orders", o);
            }
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            using (SurfboardContext context = new SurfboardContext())
            {
                Order deleteOrder = context.Orders.First(o => o.Id == id);
                context.Orders.Remove(deleteOrder);
                context.SaveChanges();
            }
            return Ok();
        }
    }
}
