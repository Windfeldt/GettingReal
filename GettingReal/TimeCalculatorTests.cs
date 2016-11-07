﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GettingReal
{

    [TestClass]
    public class TimeCalculatorTests
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
            DateTime Birthdate = new DateTime(2014, 10, 1);
            DateTime DateToday = DateTime.Today;

            string ageFormatted = cow.calculateAgeFromBirthdate(Birthdate);

            DateTimeSpan dateSpan = DateTimeSpan.CompareDates(Birthdate, DateToday);
            string dateSpanFormatted = "Years: " + dateSpan.Years + " Months " + dateSpan.Months + " Days " + dateSpan.Days;

            Assert.AreEqual(dateSpanFormatted, ageFormatted);

        }

    }
}