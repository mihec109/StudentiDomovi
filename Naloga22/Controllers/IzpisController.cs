using Microsoft.AspNetCore.Mvc;
using Naloga22.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga22.Controllers
{
    public class IzpisController : Controller
    {
        //

        // GET: /emp/



        //SqlConnection con;

        public ActionResult c()

        {
            String con2 = "Server=(localdb)\\MSSQLLocalDB;Database=a;Trusted_Connection=True;MultipleActiveResultSets=true";
            String sql = "SELECT * FROM studenti";

            var model = new List<Studenti>();
            using (SqlConnection conn = new SqlConnection(con2))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var student = new Studenti();
                    student.Ime = (string)rdr["Ime"];
                    student.Priimek = (string)rdr["Priimek"];
                    student.Vpisna_stevilka = (int)rdr["Vpisna_stevilka"];
                    model.Add(student);
                }

            }
            return View(model);

        }

        public ActionResult Delete(int Vpisna_Stevilka)
        {
            ena studenti = new ena();
            studenti.DeleteStudenti(Vpisna_Stevilka);
            if (Vpisna_Stevilka == 0)
            {
                TempData["msg_Vide"] = "Napaka! Napacno vnesena Vpisna stevilka!";
                return RedirectToAction("c");
            }
            return RedirectToAction("c");
        }
    }
}
