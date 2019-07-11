using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BLL;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private static IServiceTeste _serviceTeste;

        public HomeController(IServiceTeste serviceTeste)
        {
            _serviceTeste = serviceTeste;
        }

        public IActionResult Index()
        {
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

        [HttpGet]
        public ActionResult Action1()
        {
            var txt = _serviceTeste.Action1();

            return Content(txt, "text/html");
        }

        [HttpGet]
        public ActionResult Action2()
        {
            var txt = _serviceTeste.Action1();

            return Content(txt, "text/html");
        }

        [HttpGet]
        public ActionResult Action3()
        {
            var txt = _serviceTeste.Action1();

            return Content(txt, "text/html");
        }
    }
}
