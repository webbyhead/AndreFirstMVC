using Microsoft.AspNetCore.Mvc;
using AndreFirstMVC.Models;

namespace AndreFirstMVC.Controllers
{
    public class HelloWorldController : Controller
    {

        DogViewModel dogForm = null;

        public IActionResult Index(DogViewModel dogForm)
        {
            // DogViewModel AndreDog = new DogViewModel() { Name = "Bruno", Age = 3 };

            // return View(AndreDog);
            return View(dogForm);
        }

        public IActionResult Create()
        {
            return View();
        }

        public string hello()
        { return "Hellow this is Andre!!"; }
    }
}
