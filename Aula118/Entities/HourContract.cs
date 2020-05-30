using System;

namespace Aula118.Entities
{
    class HourContract
    {
        private DateTime date;
        private double valuePerHour;

        public DateTime Date { get => date; set => date = value; }
        public double ValuePerHour { get => valuePerHour; set => valuePerHour = value; }
    }
}
