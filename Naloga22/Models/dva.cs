using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga22.Models
{
    public class dva
    {
        SqlConnection con = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=a;Trusted_Connection=True;MultipleActiveResultSets=true");
        public string Dodaj_Dom(Domovi domovi)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Domovi_Add", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Leto_zgradnje", domovi.Leto_zgradnje);
                cmd.Parameters.AddWithValue("@Naslov", domovi.Naslov);
                cmd.Parameters.AddWithValue("@Stevilka", domovi.Stevilka);
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
        public void DeleteDom(string Naslov)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=a;Trusted_Connection=True;MultipleActiveResultSets=true";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteDom", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter();
                paramId.ParameterName = "@Naslov";
                paramId.Value = Naslov;
                cmd.Parameters.Add(paramId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
