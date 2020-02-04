using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BackendProject.Contexts;
using BackendProject.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BackendProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BongController : ControllerBase
    {
        private readonly ILogger<BongController> _logger;

        public BongController(ILogger<BongController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Bong> Get()
        {
            using (BurgerContext context = new BurgerContext())
            {
                return context.Bongs.ToList();
            }
        }
        [HttpPost]
        public IActionResult Post([FromBody] Bong newBong)
        {
            using (BurgerContext context = new BurgerContext())
            {
                context.Bongs.Add(newBong);
                context.SaveChanges();
            }
            return Created("/burger", newBong);
        }
    }
}
