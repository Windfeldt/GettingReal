﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

    }
}