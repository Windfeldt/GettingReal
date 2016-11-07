using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingReal
{
    public class Cow
    {

        public readonly static DateTime DateToday = DateTime.Today;
        public DateTime birthdate { get; set; }
        public string name { get; set; }
        public double weight { get; set; }
        int hej = 10;

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
