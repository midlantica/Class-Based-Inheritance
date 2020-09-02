using System;

namespace Class_Based_Inheritance
{
    partial class Program
    {
        public class Cessna : Vehicle // Propellor light aircraft : Parent Vehicle
        {
            public double FuelCapacity { get; set; }
            public string MainColor { get; set; }
            public string MaximumOccupancy { get; set; }

            public void RefuelTank()
            {
                Console.WriteLine("300 gallons!");
            }

            public override void Drive()
            {
                Console.WriteLine("Cessssnaaaarrrr!");
            }
        }
    }
}
