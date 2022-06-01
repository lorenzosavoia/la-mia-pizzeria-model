using Microsoft.AspNetCore.Mvc;
using la_mia_pizzeria_static.Models;

namespace la_mia_pizzeria_static.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {
            ListaPizze listapizze = new ListaPizze();
            
            Pizza PizzaMarghe = new Pizza("pizza margherita", "pomodoro mozzarella", "5€", "img\\pizzamarghe.jpeg");
            Pizza PizzaSalame = new Pizza("pizza Salame Piccante", "Pomodoro Mozzarella Salame piccante", "6€", "img\\PizzaSalame.jpeg");
            Pizza PizzaCapricciosa = new Pizza("pizza capricciosa", "Pomodoro Mozzarella Prosciutto Cotto Funghi Olive verdi e nere Carciofini", "7€", "img\\pizzacapricciosa.jpeg");
            Pizza PizzaCosacca = new Pizza("pizza cosacca", "Pomodoro Parmigiano Pecorino Basilico", "7€", "img\\pizzacosacca.jpeg");
            Pizza PizzaMontanara = new Pizza("pizza montanara", "Pizza Fritta Pomodoro Parmigiano", "3€", "img\\pizzamontanara.jpeg");

            listapizze.lsPizza.Add(PizzaMarghe);
            listapizze.lsPizza.Add(PizzaSalame);
            listapizze.lsPizza.Add(PizzaCapricciosa);
            listapizze.lsPizza.Add(PizzaCosacca);
            listapizze.lsPizza.Add(PizzaMontanara);
            
            
            return View(listapizze);
   
        }
    }
}
