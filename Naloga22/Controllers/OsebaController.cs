using Microsoft.AspNetCore.Mvc;
using Naloga22.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga22.Controllers
{
    public class OsebaController : Controller
    {
        public IActionResult efmss()
        {
            return View();
        }
        public int o;
        [HttpPost]
        public IActionResult efmss(Oseba Object)
        {
            
            Oseba oseba = new Oseba();
            if (ModelState.IsValid)
            {
                List<char> b = new List<char>();
                string a = Object.EMSO;
                foreach (char s in a)
                {
                    b.Add(s);
                }
                for(int i=0; i <= a.Length; i++)
                {
                    if(i == 0 || i == 6)
                    {
                        o = b[i] * 7;
                    }
                    else if (i == 1 || i == 7)
                    {
                        o = b[i] * 6;
                    }
                    else if (i == 2 || i == 8)
                    {
                        o = b[i] * 5;
                    }
                    else if (i == 3 || i == 9)
                    {
                        o = b[i] * 4;
                    }
                    else if (i == 4 || i == 10)
                    {
                        o = b[i] * 3;
                    }
                    else if (i == 5 || i == 11)
                    {
                        o = b[i] * 2;
                    }
                }
                int z = o % 11;
                if (z == 0)
                {
                    z = 0;
                }
                else
                {
                    z = 11 - z;
                }
                return RedirectToAction("Novoo", Object);
            }
            return View(Object);
        }
        [HttpGet]
        public IActionResult Novoo(Oseba Object)
        {
            return View(Object);
        }
    }
}
