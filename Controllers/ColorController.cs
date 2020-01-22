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
    public class ColorController : ControllerBase
    {
        private readonly ILogger<ColorController> _logger;

        public ColorController(ILogger<ColorController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public ActionResult<List<Color>> Get()
        {
            using (SurfboardContext context = new SurfboardContext())
            {
                List<Color> Colors = context.Colors.ToList();
                return Ok(Colors);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<List<Color>> Get(int id)
        {
            using (SurfboardContext context = new SurfboardContext())
            {
                Color Color = context.Colors.First(c => c.Id == id);
                return Ok(Color);
            }
        }
    }
}
