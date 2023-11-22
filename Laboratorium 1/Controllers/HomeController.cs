using Laboratorium_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Laboratorium_1.Controllers
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
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Calculator(Operator op, double? a, double? b)
        {
            if(a == null || b == null || op == Operator.Unknown)
            {
                return View("CalculatorError");
            }
            ViewBag.Op = op;
            ViewBag.a = a;
            ViewBag.b = b;
            double result = 0;
            switch (op)
            {
                case Operator.Add:
                    result = (double)(a + b); 
                    break;
                case Operator.Sub:
                    result = (double)(a - b);
                    break;
                case Operator.Div:
                    result = (double)(a / b);
                    break;
                case Operator.Mul:
                    result = (double)(a * b);
                    break;
            }
            ViewBag.result = result;
            return View();
        }

        public enum Operator
        {
            Unknown, Add, Mul, Sub, Div
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