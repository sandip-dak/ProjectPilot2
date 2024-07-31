using Microsoft.AspNetCore.Mvc;

namespace ProjectPilot2.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AboutUs()
        {
            return View();
            
        }
    }
}
