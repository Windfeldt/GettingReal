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

        private static SqlConnection dbConn;
        

        static CowCRUD()
        {

            dbConn = new SqlConnection("Data Source=" + "ealdb1.eal.local" + ";Initial Catalog=" + "ejl38_db" + ";User ID=" + "ejl38_usr" + ";Password=" + "Baz1nga38");

        }

        public static int Create(Cow cow)
        {

            cow.calculateMaturationDate();
            cow.calculateDeliveryDate();
            string sqlString = "INSERT INTO GettingReal_Calves (CHR, Name, Birthdate, Birthweight, DeliveryDate, MaturationDate, OwnerID) VALUES (" + cow.CHR + ", '" + cow.name + "', '" + cow.birthdate.ToShortDateString() + "', " + cow.birthweight + ", '" + cow.deliveryDate.ToShortDateString() + "', '" + cow.maturationDate.ToShortDateString() + "', " + cow.ownerId + ")";
            SqlCommand cmd = new SqlCommand(sqlString, dbConn);

            dbConn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();
            dbConn.Close();

            return rowsAffected;
        }

        public static void Read()
        {

        }

        public static void Update()
        {

        }

        public static void Delete()
        {

        }

    }
}
