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
        public int CHR { get; set; }
        public string name { get; set; }
        public DateTime birthdate { get; set; }
        public string age { get; set; }
        public double birthweight { get; set; }
        public double currentWeight { get; set; }
        public DateTime deliveryDate { get; set; }
        public DateTime maturationDate { get; set; }
        public int ownerId { get; set; }

        // Regner den nuværende alder ud fra fødselsdatoen til dagsdato.
        public void calculateAgeFromBirthdate()
        {

            DateTimeSpan dateSpan = DateTimeSpan.CompareDates(this.birthdate, DateToday);
            string AgeFormatted = "Years: " + dateSpan.Years + " Months: " + dateSpan.Months + " Days: " + dateSpan.Days;
            this.age = AgeFormatted;

        }

        public void calculateWeightFromBirthdateAndBirthweight()
        {

            // Udregn antal dage fra kalvens fødselsdag til dags dato.
            double days = (DateToday - this.birthdate).TotalDays;
            double daysOver2Years = 0;

            // Hvis kalven er ældre end 2 år, så læg de overskydende dage over i "daysOver2Years" og træk dem fra "days".
            // På denne måde kan man bruge forskellige udregninger på de forskellige dage.
            if (days - 730 > 0)
            {
                daysOver2Years = days - 730;
                days = days - daysOver2Years;
            }

            // Regner den samlede nuværende vægt ud.
            this.currentWeight = this.birthweight + days * 0.75 + daysOver2Years * 1.5;

        }

        // Tilføj 24 måneder til fødselsdatoen for at finde modningsdatoen. 
        public void calculateMaturationDate()
        {

            this.maturationDate = this.birthdate.AddMonths(24);

        }

        // Tilføj 26 måneder til fødselsdatoen for at finde afleveringsdatoen.
        public void calculateDeliveryDate()
        {

            this.deliveryDate = this.birthdate.AddMonths(26);

        }

    }
}