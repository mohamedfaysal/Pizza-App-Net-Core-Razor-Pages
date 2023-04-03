using Microsoft.AspNetCore.Mvc;
using pizza_zoe.Data;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizza_zoe.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : Controller
    {
        DataContext dataContext;

        public ApiController(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }  




        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {
            var pizzas = dataContext.Pizzas.ToList();

            return Json(pizzas);
        }

    }
}
