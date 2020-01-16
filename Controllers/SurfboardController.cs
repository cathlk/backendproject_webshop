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
        public IEnumerable<Surfboard> Get()
        {
            using (SurfboardContext context = new SurfboardContext())
            {
                return context.Surfboards.ToList();
            }
        }
    }
}
