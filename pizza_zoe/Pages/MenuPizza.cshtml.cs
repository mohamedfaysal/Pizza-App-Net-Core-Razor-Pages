using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pizza_zoe.Data;
using pizza_zoe.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pizza_zoe.Pages
{
    public class MenuPizzaModel : PageModel
    {
        private readonly pizza_zoe.Data.DataContext dataContext;

        public MenuPizzaModel(DataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public IList<Pizza> Pizza { get; set; }
        public async Task OnGet()
        {
            Pizza = await dataContext.Pizzas.ToListAsync();
            Pizza = Pizza.OrderBy(p => p.prix).ToList();
        }
    }
}
