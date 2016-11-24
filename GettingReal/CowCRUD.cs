using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    static class CowCRUD
    {

        private readonly static SqlConnection dbConn;
        
        static CowCRUD()
        {

            dbConn = new SqlConnection("Data Source=" + "ealdb1.eal.local" + ";Initial Catalog=" + "ejl38_db" + ";User ID=" + "ejl38_usr" + ";Password=" + "Baz1nga38");

        }

        public static int Create(Cow cow)
        {
            string sqlString = "INSERT INTO GettingReal_Calves (CHR, Name, Birthdate, Birthweight, DeliveryDate, MaturationDate, OwnerID) VALUES (" + cow.CHR + ", '" + cow.name + "', '" + cow.birthdate.ToShortDateString() + "', " + cow.birthweight + ", '" + cow.deliveryDate.ToShortDateString() + "', '" + cow.maturationDate.ToShortDateString() + "', " + cow.ownerId + ")";
            SqlCommand cmd = new SqlCommand(sqlString, dbConn);

            dbConn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            dbConn.Close();

            return rowsAffected;
        }

        public static SqlDataReader Read()
        {
            string sqlString = "SELECT CHR, Name, Birthdate, Birthweight, DeliveryDate, MaturationDate, OwnerID FROM GettingReal_Calves";
            SqlCommand cmd = new SqlCommand(sqlString, dbConn);

            dbConn.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            //dbConn.Close();

            // Nedenstående vil kunne udskrive de rækker og columns som bliver valgt af sql sætningen.
            /*while (reader.Read())
            {
                Console.WriteLine(reader.GetValue(0));
            }*/

            return reader;
        }

        public static int Update(Cow cow)
        {
            string sqlString = "UPDATE GettingReal_Calves SET CHR=" + cow.CHR + ", Name='" + cow.name + "', Birthdate='" + cow.birthdate.ToShortDateString() + "', Birthweight=" + cow.birthweight + ", DeliveryDate='" + cow.deliveryDate.ToShortDateString() + "', MaturationDate='" + cow.maturationDate.ToShortDateString() + "', OwnerID=" + cow.ownerId + " WHERE CHR=" + cow.CHR;
            SqlCommand cmd = new SqlCommand(sqlString, dbConn);

            dbConn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            dbConn.Close();

            return rowsAffected;
        }

        public static int Delete(Cow cow)
        {
            string sqlString = "DELETE FROM GettingReal_Calves WHERE CHR = " + cow.CHR;
            SqlCommand cmd = new SqlCommand(sqlString, dbConn);

            dbConn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            dbConn.Close();

            return rowsAffected;
        }

        public static void DbConnClose()
        {
            dbConn.Close();
        }

    }
}
