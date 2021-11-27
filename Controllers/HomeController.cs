using LaKeyDiVolta.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LaKeyDiVolta.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() //Stesso nome della View Index
        {
            ViewData["Message"] = "CD-Keys a prezzi bassi e fissi";
            return View();
        }

        public IActionResult About()
        {
            return new ViewResult() { ViewName = "About" };
        }
    
    }
}