using System;

namespace Class_Based_Inheritance
{
    partial class Program
    {
        public class Vehicle  // Parent class
        {
            public string Name { get; set; }
            public string MainColor { get; set; }
            public string MaximumOccupancy { get; set; }
            public string Sound { get; set; }
            public virtual void Drive()
            {
                Console.WriteLine(Sound);
            }
        }
    }
}
