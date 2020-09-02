using System;
using System.Security.Cryptography.X509Certificates;

namespace Class_Based_Inheritance
{
    partial class Program
    {
        public class Zero : Vehicle  // Electric motorcycle : Parent Vehicle
        {
            public double BatteryKWh { get; set; }
            public string MainColor { get; set; }
            public string MaximumOccupancy { get; set; }
            public void ChargeBattery()
            {
                Console.WriteLine("440 Watts");
            }

            public override void Drive()
            {
                Console.WriteLine(Sound);
            }
        }
    }
}
