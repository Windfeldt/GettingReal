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
        public int id { get; set; }
        public string name { get; set; }
        public DateTime birthdate { get; set; }
        public string age { get; set; }
        public double birthWeight { get; set; }
        public double currentWeight { get; set; }
        public DateTime deliveryDate { get; set; }
        public DateTime maturationDate { get; set; }

        public void calculateAgeFromBirthdate(DateTime Birthdate)
        {

            DateTimeSpan dateSpan = DateTimeSpan.CompareDates(Birthdate, DateToday);
            string AgeFormatted = "Years: " + dateSpan.Years + " Months: " + dateSpan.Months + " Days: " + dateSpan.Days;
            this.age = AgeFormatted;

        }

    }
}
