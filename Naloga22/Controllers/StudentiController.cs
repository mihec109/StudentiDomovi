using Microsoft.AspNetCore.Mvc;
using Naloga22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga22.Controllers
{
    public class StudentiController : Controller
    {
        public IActionResult efms()
        {
            return View();
        }

        [HttpPost]
        public IActionResult efms(Studenti Object)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Novo", Object);
            }
            return View(Object);
        }
        [HttpGet]
        public IActionResult Novo(Studenti Object)
        {
            return View(Object);
        }
    }
}
