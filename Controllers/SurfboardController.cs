using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using firstTry.Contexts;
using firstTry.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace firstTry.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SurfboardController : ControllerBase
    {
        private readonly ILogger<SurfboardController> _logger;

        public SurfboardController(ILogger<SurfboardController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public ActionResult<List<Surfboard>> Get()
        {
            using (SurfboardContext context = new SurfboardContext())
            {
                List<Surfboard> Surfboards = context.Surfboards.Include(s => s.Colors).ToList();
                return Ok(Surfboards);
            }
        }
        [HttpPost]
        public IActionResult Post([FromBody] Surfboard newSurfboard)
        {
            using (SurfboardContext context = new SurfboardContext())
            {
                context.Surfboards.Add(newSurfboard);
                context.SaveChanges();
            }
            return Created("/surfboards", newSurfboard);
        }

        // [HttpPut("{id}")]
        // public IActionResult;

        // [HttpDelete("{id}")]
        // public IActionResult;


    }
}
