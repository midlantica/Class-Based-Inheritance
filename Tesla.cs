using System;

namespace Class_Based_Inheritance
{
    partial class Program
    {
        public class Tesla : Vehicle  // Electric car : Parent Vehicle
        {
            public double BatteryKWh { get; set; }
            public string MainColor { get; set; }
            public string MaximumOccupancy { get; set; }
            public void ChargeBattery()
            {
                Console.WriteLine("300 Watts");
            }

            public override void Drive()
            {
                Console.WriteLine(Sound);
            }
        }
    }
}
