using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public class TimeCalculator
    {

        public readonly static DateTime DateToday = DateTime.Today;

        public string calculateAgeFromBirthdate(DateTime Birthdate)
        {

            DateTimeSpan dateSpan = DateTimeSpan.CompareDates(Birthdate, DateToday);
            string AgeFormatted = "Years: " + dateSpan.Years + " Months " + dateSpan.Months + " Days " + dateSpan.Days;
            return AgeFormatted;

        }

        public DateTime calulateBirthdateFromAge(DateTime Age)
        {

            throw new NotImplementedException();

        }

    }
}
