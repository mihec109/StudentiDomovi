using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Naloga22.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga22.Controllers
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
        public IActionResult Studenti()
        {
            

            return View();
        }

        public IActionResult Registracijaa2()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registracijaa2(Oseba Object)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Registracijaa23", Object);
            }
            return View(Object);
        }

        [HttpGet]
        public IActionResult Registracijaa23(Oseba Object)
        {
            return View(Object);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Registracija()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registracija(string Ime, string Priimek, DateTime Datum_rojstva, int EMSO, int Starost)
        {
            if (Ime != null && Priimek != null && EMSO != 0 && Starost != 0)
            {
                TempData["Ime"] = Ime;
                TempData["Priimek"] = Priimek;
                TempData["Datum rojstva"] = Datum_rojstva;
                TempData["EMSO"] = EMSO;
                TempData["Starost"] = Starost;

                return RedirectToAction("Registracija2");
            }
            return RedirectToAction("Registracija");
        }
        public IActionResult Registracija2()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registracija2(string Naslov, int Postna_stevilka, string Posta, string Drzava)
        {
            if (Naslov != null && Postna_stevilka != 0 && Posta != null && Drzava != null)
            {
                TempData["Naslov"] = Naslov;
                TempData["Postna_stevilka"] = Postna_stevilka;
                TempData["Posta"] = Posta;
                TempData["Drzava"] = Drzava;

                return RedirectToAction("Registracija3");
            }
            return RedirectToAction("Registracija2");
        }
        public ActionResult Registracija3()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Registracija3(string Eposta, string Geslo, string Ponovno_geslo)
        {
            if (Eposta != null && Geslo != null && Ponovno_geslo != null)
            {
                if (Geslo == Ponovno_geslo)
                {
                    TempData["E-posta"] = Eposta;
                    TempData["Geslo"] = Geslo;
                    TempData["Ponovnovgeslo"] = Ponovno_geslo;
                }
                else
                {
                    return RedirectToAction("Registracija3");
                }

                return RedirectToAction("Registracija4");
            }
            return RedirectToAction("Registracija3");
        }
        public ActionResult Registracija4()
        {
            return View();
        }


    }
}
