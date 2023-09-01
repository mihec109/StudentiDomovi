using Microsoft.AspNetCore.Mvc;
using Naloga22.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga22.Controllers
{
    public class Izpis3Controller : Controller
    {
        public ActionResult ccc()

        {
            String con2 = "Server=(localdb)\\MSSQLLocalDB;Database=a;Trusted_Connection=True;MultipleActiveResultSets=true";
            String sql = "SELECT * FROM uporabniki";

            var model = new List<Uporabniki>();
            using (SqlConnection conn = new SqlConnection(con2))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var uporabniki = new Uporabniki();
                    uporabniki.Username = (string)rdr["Username"];
                    uporabniki.Password = (string)rdr["Password"];
                    uporabniki.Email = (string)rdr["Email"];
                    model.Add(uporabniki);
                }

            }

            return View(model);

        }

        public ActionResult Delete(string Email)
        {
            tri uporabniki = new tri();
            uporabniki.DeleteUporabniki(Email);
            return RedirectToAction("ccc");
        }
    }
}
