using Microsoft.AspNetCore.Mvc;
using Naloga22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga22.Controllers
{
    public class DBBController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        ena empdb = new ena();

        [HttpGet]
        public IActionResult b()
        {
            return View();
        }
        [HttpPost]
        public IActionResult b([Bind] Studenti studenti)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string resp = empdb.Dodaj_studenta(studenti);
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
