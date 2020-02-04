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
    public class IngredientsController : ControllerBase
    {
        private readonly ILogger<IngredientsController> _logger;

        public IngredientsController(ILogger<IngredientsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Ingredient> Get()
        {
            using (BurgerContext context = new BurgerContext())
            {
                return context.Ingredients.ToList();
            }
        }
        [HttpPost]
        public IActionResult Post([FromBody] Ingredient newIngredient)
        {
            using (BurgerContext context = new BurgerContext())
            {
                context.Ingredients.Add(newIngredient);
                context.SaveChanges();
            }
            return Created("/burger", newIngredient);
        }
    }
}
