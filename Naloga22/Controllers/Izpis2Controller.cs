using Microsoft.AspNetCore.Mvc;
using Naloga22.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga22.Controllers
{
    public class Izpis2Controller : Controller
    {
        public ActionResult cc()

        {
            String con2 = "Server=(localdb)\\MSSQLLocalDB;Database=a;Trusted_Connection=True;MultipleActiveResultSets=true";
            String sql = "SELECT * FROM domovi";

            var model = new List<Domovi>();
            using (SqlConnection conn = new SqlConnection(con2))
            {
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    var domovi = new Domovi();
                    domovi.Leto_zgradnje = (int)rdr["Leto_zgradnje"];
                    domovi.Naslov = (string)rdr["Naslov"];
                    domovi.Stevilka = (int)rdr["Stevilka"];
                    model.Add(domovi);
                }

            }

            return View(model);

        }

        public ActionResult Delete(string Naslov)
        {
            dva domovi = new dva();
            domovi.DeleteDom(Naslov);
            return RedirectToAction("cc");
        }

    }
}
