using Microsoft.AspNetCore.Mvc;
using Naloga22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga22.Controllers
{
    public class DBB3Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        tri empdb = new tri();

        [HttpGet]
        public IActionResult bbb()
        {
            return View();
        }
        [HttpPost]
        public IActionResult bbb([Bind] Uporabniki uporabniki)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string resp = empdb.Dodaj_Uporabnika(uporabniki);
                    TempData["msg"] = resp;
                }
            }
            catch (Exception ex)
            {
                TempData["msg"] = ex.Message;
            }
            return View();
        }
    }
}
