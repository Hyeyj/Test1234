using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Test1234.Models;

namespace Test1234.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult OneStar
        {
            get
            {
                for (int i = 1; i <= 5; i++)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }

                return View();
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}