using Microsoft.AspNetCore.Mvc;

namespace La_mia_Pizzeria.Controllers
{
    public class PizzaController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
