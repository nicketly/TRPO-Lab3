using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TRPO_Lab3.Lib;
using TRPO_Lab3.WebApp.Models;

namespace TRPO_Lab3.WebApp.Controllers
{
    public class CustomController : Controller
    {
        public ActionResult Custom_View(double length, double height)
        {
            var volume = FormulaLib.Pyramid_Reg4_Volume(length, height);
            var vm = new CustomModel(length, height, volume);
            return View(vm);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Custom_View(IFormCollection collection, double length, double height)
        {
            var volume = FormulaLib.Pyramid_Reg4_Volume(length, height);
            var vm = new CustomModel(length, height, volume);
            return View(vm);
        }
    }
}
