using Microsoft.AspNetCore.Mvc;

namespace webApp.Controllers
{
    public class FoodOrders : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Users()
        {
            return View("Users");
        }

        public IActionResult Toppings(string name, int numberOfTopping)
        {
            ViewBag.Name = name;    
            ViewBag.NumberOfToppings = numberOfTopping; 
            return View();
        }
    }
}
