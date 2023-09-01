using Microsoft.AspNetCore.Mvc;
using Naloga22.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga22.Controllers
{
    public class DBB4Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        tri empdb = new tri();

        [HttpGet]
        public IActionResult bbbb()
        {
            return View();
        }

        [HttpPost]
        public IActionResult bbbb(string name)
        {
            //SqlConnection conn = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=a;Trusted_Connection=True;MultipleActiveResultSets=true");
            //SqlCommand check_User_Name = new SqlCommand("SELECT COUNT(*) FROM Uporabniki WHERE (Username = @Username)", conn);
            //check_User_Name.Parameters.AddWithValue("@Username", name);
            //conn.Open();
            //int UserExist = (int)check_User_Name.ExecuteScalar();

            //if (UserExist > 0)
            //{
            //    //Username exist
            //    int a = 0;
            //    a = a + 2;
            //}
            //else
            //{
            //    //Username doesn't exist.
            //    int b = 0;
            //    b = b + 2;
            //}
            //return View();
            ////////////////////////////
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
            return View();
        }
        
    }
}
