using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.SqlClient;

namespace GettingReal
{

    [TestClass]
    public class CowTests
    {

        [TestMethod]
        public void returnTodaysDate()
        {

            Assert.AreEqual(DateTime.Today, Cow.DateToday);

        }

        [TestMethod]
        public void canCalculateAgeFromBirthdate()
        {

            Cow cow = new Cow();
            cow.birthdate = new DateTime(2014, 10, 1);
            cow.calculateAgeFromBirthdate();

            DateTime DateToday = DateTime.Today;
            DateTime Birthdate = new DateTime(2014, 10, 1);
            DateTimeSpan dateSpan = DateTimeSpan.CompareDates(Birthdate, DateToday);
            string dateSpanFormatted = "Years: " + dateSpan.Years + " Months: " + dateSpan.Months + " Days: " + dateSpan.Days;

            Assert.AreEqual(dateSpanFormatted, cow.age);

        }

        [TestMethod]
        public void canCalculateWeightFromBirthdate()
        {

            Cow cow = new Cow();
            cow.birthdate = new DateTime(2014, 9, 8);
            cow.birthweight = 45;
            cow.calculateWeightFromBirthdateAndBirthweight();

            double days = (DateTime.Today - cow.birthdate).TotalDays;
            double daysOver2Years = 0;

            if (days - 730 > 0)
            {
                daysOver2Years = days - 730;
                days = days - daysOver2Years;
            }

            double birthweight = cow.birthweight + days * 0.75 + daysOver2Years * 1.5;

            Assert.AreEqual(birthweight, cow.currentWeight);

        }

        [TestMethod]
        public void canCalculateMaturationDate()
        {

            Cow cow = new Cow();
            cow.birthdate = new DateTime(2014, 10, 1);
            cow.calculateMaturationDate();

            DateTime expected = new DateTime(2016, 10, 1);

            Assert.AreEqual(expected, cow.maturationDate);

        }

        [TestMethod]
        public void canCalculateDeliveryDate()
        {

            Cow cow = new Cow();
            cow.birthdate = new DateTime(2014, 10, 1);
            cow.calculateDeliveryDate();

            DateTime expected = new DateTime(2016, 12, 1);

            Assert.AreEqual(expected, cow.deliveryDate);

        }

        /*[TestMethod]
        public void sendSqlInsertToDatabase()
        {

            Cow cow = new Cow();
            cow.CHR = 5664566;
            cow.name = "Ole Henriksen";
            cow.birthdate = new DateTime(2014, 10, 1);
            cow.birthweight = 45;
            cow.ownerId = 1;
            cow.calculateMaturationDate();
            cow.calculateDeliveryDate();

            int rowsAffected = CowCRUD.Create(cow);

            Assert.AreEqual(1, rowsAffected);

        }*/

        /*[TestMethod]
        public void sendSqlUpdateToDatabase()
        {

            Cow cow = new Cow();
            cow.CHR = 5664566;
            cow.name = "Ole Henriksen Jr";
            cow.birthdate = new DateTime(2014, 10, 1);
            cow.birthweight = 45;
            cow.ownerId = 1;
            cow.calculateMaturationDate();
            cow.calculateDeliveryDate();

            int rowsAffected = CowCRUD.Update(cow);

            Assert.AreEqual(1, rowsAffected);

        }*/

        /*[TestMethod]
        public void sendSqlDeleteToDatabase()
        {

            Cow cow = new Cow();
            cow.CHR = 5664566;
            cow.name = "Ole Henriksen";
            cow.birthdate = new DateTime(2014, 10, 1);
            cow.birthweight = 45;
            cow.ownerId = 1;
            cow.calculateMaturationDate();
            cow.calculateDeliveryDate();

            int rowsAffected = CowCRUD.Delete(cow);

            Assert.AreEqual(1, rowsAffected);

        }*//*
        [TestMethod]
        public void CanGetFromInputFrom_NyKalv()
        {
            Cow cow = new Cow();
            Assert.AreEqual("Simon", cow.name);
        }*/

        // SKRIV DENNE TEST/KODE FÆRDIG
        [TestMethod]
        public void sendSqlSelectToDatabase()
        {

            SqlDataReader reader = CowCRUD.Read();
            reader.Read();

            Assert.AreEqual(5664564, reader.GetValue(0));

        }
    }
}
