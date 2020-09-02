using System;

namespace Class_Based_Inheritance
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CLASS BASED INHERITANCE");
            Console.WriteLine("-----------------------");

            Zero fxs = new Zero();
            fxs.Name = "Zero FXS";
            fxs.MainColor = "Red";
            fxs.BatteryKWh = 2.5;
            fxs.MaximumOccupancy = "2";
            fxs.Sound = "Zerrrrrrrrrrroo!";
            Console.WriteLine($"The {fxs.MainColor} {fxs.Name} fits {fxs.MaximumOccupancy} and goes {fxs.Sound}\n");
            //fxs.Drive();
            //fxs.ChargeBattery();

            Tesla modelS = new Tesla();
            modelS.Name = "Tesla Model S";
            modelS.MainColor = "Silver";
            modelS.BatteryKWh = 5.25;
            modelS.MaximumOccupancy = "4";
            modelS.Sound = "Tessslllaaaarrr!";
            Console.WriteLine($"The {modelS.MainColor} {modelS.Name} fits {modelS.MaximumOccupancy} and goes {modelS.Sound}\n");
            //modelS.Drive();
            //modelS.ChargeBattery();

            Cessna mx410 = new Cessna();
            mx410.Name = "Cessna MX 410";
            mx410.MainColor = "cream";
            mx410.MaximumOccupancy = "4";
            mx410.Sound = "Cessssnaaaaaa!";
            Console.WriteLine($"The {mx410.MainColor} {mx410.Name} fits {mx410.MaximumOccupancy} and goes {mx410.Sound}\n");
            //mx410.Drive();
            //mx410.RefuelTank();

            Ram r1000 = new Ram();
            r1000.Name = "Ram R1000";
            r1000.MainColor = "red";
            r1000.MaximumOccupancy = "6";
            r1000.Sound = "Raaammmmmmmrrr!";
            Console.WriteLine($"The {r1000.MainColor} {r1000.Name} fits {r1000.MaximumOccupancy} and goes {r1000.Sound}\n");
            //r1000.Drive();
            //r1000.RefuelTank();

            Console.WriteLine("=======================");
            Console.WriteLine();
        }
    }
}

