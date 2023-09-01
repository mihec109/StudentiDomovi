using Microsoft.AspNetCore.Mvc;
using Naloga22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga22.Controllers
{
    public class DBB2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        dva empdb = new dva();

        [HttpGet]
        public IActionResult bb()
        {
            return View();
        }
        [HttpPost]
        public IActionResult bb([Bind] Domovi domovi)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    string resp = empdb.Dodaj_Dom(domovi);
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
