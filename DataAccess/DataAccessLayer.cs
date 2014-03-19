using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TimetablingSystem1.DataAccess
{
    public class DataAccessLayer
    {
       //static SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["team02database"].ConnectionString.ToString());
        static SqlConnection conn = new SqlConnection("Data Source=co-web.lboro.ac.uk;Integrated Security=False;User ID=team02;Password=s9s38vb;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False");
        

       

        public static bool UserIsValid(string username, string password)
        {
            
                bool authenticated = false;

                string query = string.Format("SELECT * FROM TestLogin WHERE Username = '{0}' AND Password = '{1}'", username, password);

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                authenticated = sdr.HasRows;
                conn.Close();
                return (authenticated);

                          
            

        }
    }
}