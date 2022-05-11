using Microsoft.AspNetCore.Mvc;
using AndreFirstMVC.Models;

namespace AndreFirstMVC.Controllers
{
    public class HelloWorldController : Controller
    {


        public IActionResult Index()
        {
            DogViewModel AndreDog = new DogViewModel() { Name = "Bruno", Age = 3 };
            return View(AndreDog);
        }

        public IActionResult Create()
        {
            return View();
        }

        public string hello()
        { return "Hellow this is Andre!!"; }
    }
}
