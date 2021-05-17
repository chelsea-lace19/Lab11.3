using Lab11._2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;


namespace Lab11._2.Controllers
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

        public IActionResult registrationform()
        {
            return View();
        }

        [HttpPost]
        public IActionResult formresponse(Customer newCust)
        {
            if (newCust.Email != newCust.Email2)
            {        
                return RedirectToAction("registrationformerror1");
            }

            else if (newCust.Password != newCust.Password2)
            {
                return RedirectToAction("registrationformerror2");
            }

            return View(newCust);

        }

        public IActionResult registrationformerror1()
        {
            return View();
        }
        public IActionResult registrationformerror2()
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
    }
}
