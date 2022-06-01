using la_mia_pizzeria_static.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace la_mia_pizzeria_static.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            
            ViewData["pizza1"] = "Pizza Margherita";
            ViewData["pizza2"] = "Pizza Salame Piccante";
            ViewData["pizza3"] = "Pizza Capricciosa";
            ViewData["pizza4"] = "Pizza Cosacca";
            ViewData["pizza5"] = "Pizza Montanara";

            ViewData["pizza1Desc"] = "Pomodoro Mozzarella";
            ViewData["pizza2Desc"] = "Pomodoro Mozzarella Salame piccante";
            ViewData["pizza3Desc"] = "Pomodoro Mozzarella Prosciutto Cotto Funghi Olive verdi e nere Carciofini";
            ViewData["pizza4Desc"] = "Pomodoro Parmigiano Pecorino Basilico";
            ViewData["pizza5Desc"] = "Pizza Fritta Pomodoro Parmigiano";

            ViewData["pizza1Price"] = "5€";
            ViewData["pizza2Price"] = "6€";
            ViewData["pizza3Price"] = "7€";
            ViewData["pizza4Price"] = "4€";
            ViewData["pizza5Price"] = "3€";

            ViewData["pizza1Img"] = "img\\pizzamarghe.jpeg";
            ViewData["pizza2Img"] = "img\\PizzaSalame.jpeg";
            ViewData["pizza3Img"] = "img\\pizzacapricciosa.jpeg";
            ViewData["pizza4Img"] = "img\\pizzacosacca.jpeg";
            ViewData["pizza5Img"] = "img\\pizzamontanara.jpeg";





            return View();
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