using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga22.Models
{
    public class tri
    {
        SqlConnection con = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=a;Trusted_Connection=True;MultipleActiveResultSets=true");
        public string Dodaj_Uporabnika(Uporabniki uporabniki)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Uporabniki_Add", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", uporabniki.Username);
                cmd.Parameters.AddWithValue("@Password", uporabniki.Password);
                cmd.Parameters.AddWithValue("@Email", uporabniki.Email);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Data save Successfully");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return (ex.Message.ToString());
            }
        }
        public void DeleteUporabniki(string Email)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=a;Trusted_Connection=True;MultipleActiveResultSets=true";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteUporabniki", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter();
                paramId.ParameterName = "@Email";
                paramId.Value = Email;
                cmd.Parameters.Add(paramId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
