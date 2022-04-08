using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Mototrcycle : Vehicle
    {
        public Mototrcycle()
        {
        }
        public string EngineNoise { get; set; } 

        public override void DriveAbstract()
        {
            Console.WriteLine($"Im driving my {GetType().Name} which is a {GetType().BaseType.Name} in an abstract method ");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"Im driving my motorcycle virtually");
        }
    }
}
