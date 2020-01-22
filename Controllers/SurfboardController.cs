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
                List<Surfboard> Surfboards = context.Surfboards.ToList();
                return Ok(Surfboards);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<List<Surfboard>> Get(int id)
        {
            using (SurfboardContext context = new SurfboardContext())
            {
                Surfboard Board = context.Surfboards.First(c => c.Id == id);
                return Ok(Board);
            }
        }

        // [HttpPost]
        // public IActionResult Post([FromBody] Surfboard newSurfboard)
        // {
        //     using (SurfboardContext context = new SurfboardContext())
        //     {
        //         context.Surfboards.Add(newSurfboard);
        //         context.SaveChanges();
        //     }
        //     return Created("/surfboards", newSurfboard);
        // }

        // [HttpPut("{id}")]
        // public IActionResult Put(int id, [FromBody] Surfboard s)
        // {
        //     using (SurfboardContext context = new SurfboardContext())
        //     {
        //         Surfboard toUpdate = context.Surfboards.First(s => s.Id == id);
        //         toUpdate.Shape = s.Shape;

        //         context.SaveChanges();
        //     }
        //     return Ok();
        // }

        // [HttpDelete("{id}")]
        // public IActionResult Delete(int id)
        // {
        //     using (SurfboardContext context = new SurfboardContext())
        //     {
        //         Surfboard toDelete = context.Surfboards.First(s => s.Id == id);
        //         context.Surfboards.Remove(toDelete);
        //         context.SaveChanges();
        //     }
        //     return Ok();
        // }
    }
}
