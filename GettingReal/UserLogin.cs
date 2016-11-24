using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    static class UserLogin
    {

        public static void Login(string username, string password)
        {

            using (SqlConnection conn = new SqlConnection("Data Source=" + "ealdb1.eal.local" + ";Initial Catalog=" + "ejl38_db" + ";User ID=" + "ejl38_usr" + ";Password=" + "Baz1nga38"))
            {

                conn.Open();

                try
                {

                    string sqlString = "SELECT id, Name FROM GettingReal_Owners WHERE Username = @username AND Password = @password";
                    SqlCommand cmd = new SqlCommand(sqlString, conn);

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows == true)
                    {

                        reader.Read();
                        User.id = Convert.ToInt32(reader.GetValue(0));
                        User.name = Convert.ToString(reader.GetValue(1));

                    }

                }
                catch (SqlException e)
                {
                    Console.WriteLine("An error occured with the connection:" + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine("An unspecified error happened:" + e.Message);
                }


            }

        }
    }
}
