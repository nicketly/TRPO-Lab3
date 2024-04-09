using Microsoft.AspNetCore.Mvc;
using TRPO_Lab3.Lib;
using TRPO_Lab3.WebApp.Models;

namespace TRPO_Lab3.WebApp.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index(double length, double height)
        {
            var volume = FormulaLib.Pyramid_Reg4_Volume(length, height);
            var vm = new MyModel(length, height, volume);
            return View(vm);
        }

        public IActionResult Test(IFormCollection collection, double length, double height)
        {
            var volume = FormulaLib.Pyramid_Reg4_Volume(length, height);
            var vm = new MyModel(length, height, volume);
            return View(vm);
        }
    }
}
