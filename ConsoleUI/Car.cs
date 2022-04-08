using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public Car()
        {

        }
        public int NumberOfDoors { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine($"Im driving my {GetType().Name} in an abstract method. It is a {GetType().BaseType.Name}");
        }
    }
}
