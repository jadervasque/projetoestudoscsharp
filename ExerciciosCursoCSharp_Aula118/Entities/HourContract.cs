using System;

namespace Aula118.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }

        public override string ToString()
        {
            return $"{Date.ToShortDateString()}, ValuePerHour: {ValuePerHour.ToString("F2")}, Hours: {Hours}";
        }
    }


}
