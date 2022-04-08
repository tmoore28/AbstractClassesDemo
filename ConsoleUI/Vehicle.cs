using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "1995";
        public string Make { get; set; } = "Chevy";
        public string Model { get; set; } = "4x4";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"Im driving my virtual vehicle");
        }


    }
}
