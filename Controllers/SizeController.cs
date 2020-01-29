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
    public class SizeController : ControllerBase
    {
        private readonly ILogger<SizeController> _logger;

        public SizeController(ILogger<SizeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]
        public ActionResult<List<Size>> Get()
        {
            using (SurfboardContext context = new SurfboardContext())
            {
                List<Size> Sizes = context.Sizes.ToList();
                return Ok(Sizes);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<List<Size>> Get(int id)
        {
            using (SurfboardContext context = new SurfboardContext())
            {
                Size Size = context.Sizes.First(c => c.Id == id);
                return Ok(Size);
            }
        }
    }
}
