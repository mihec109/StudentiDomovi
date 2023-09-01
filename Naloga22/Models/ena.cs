using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Naloga22.Models
{
    public class ena
    {
        SqlConnection con = new SqlConnection("Server=(localdb)\\MSSQLLocalDB;Database=a;Trusted_Connection=True;MultipleActiveResultSets=true");
        public string Dodaj_studenta(Studenti studenti)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Studenti_Add", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ime", studenti.Ime);
                cmd.Parameters.AddWithValue("@Priimek", studenti.Priimek);
                cmd.Parameters.AddWithValue("@Vpisna_stevilka", studenti.Vpisna_stevilka);
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
        public void DeleteStudenti(int Vpisna_Stevilka)
        {
            string connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=a;Trusted_Connection=True;MultipleActiveResultSets=true";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spDeleteStudenti", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter paramId = new SqlParameter();
                paramId.ParameterName = "@Vpisna_Stevilka";
                paramId.Value = Vpisna_Stevilka;
                cmd.Parameters.Add(paramId);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
