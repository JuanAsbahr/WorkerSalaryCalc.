using System;

namespace WorkerSalary.Entities
{
    internal class HourContract
    {
        public DateTime Date { get ; set; }
        public double ValuePerHouer { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract (DateTime date, double valuePerHouer, int hours)
        {
            Date = date;
            ValuePerHouer = valuePerHouer;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHouer;
        }

    }
}
