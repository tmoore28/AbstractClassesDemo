using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle...DONE...
             * The vehicle class shall have three string properties Year, Make, and Model...done
             * Set the defaults to something generic in the Vehicle class.......done
             * Vehicle shall have an abstract method called DriveAbstract with no implementation........done
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.....done
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicle

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            var car1 = new Car() { Year = "1995", Make = "Nissan", Model = "Altima", NumberOfDoors = 2};
            
            var moto1 = new Mototrcycle() { Year = "2022", Make = "Harley Davidson", Model = "Cruiser", EngineNoise = "VROOOM!"};

            Vehicle car2 = new Car() {Year = "2018", Make = "Chevy", Model = "Trax", NumberOfDoors = 4};

            Vehicle moto2 = new Mototrcycle() { Make = "Honda", Model = "Cb900", Year = "1990", EngineNoise = "RummmmRUUUUMMM" };

            vehicles.Add(car1);
            vehicles.Add(moto1);
            vehicles.Add(moto2);
            vehicles.Add(car2);

            foreach (var item in vehicles)
            {
                Console.WriteLine($"{item.Make}, {item.Year}, {item.Model}\n");
            }

            car1.DriveVirtual();
            Console.WriteLine();
            car1.DriveAbstract();
            Console.WriteLine();

            moto1.DriveAbstract();
            Console.WriteLine();
            moto2.DriveVirtual();
            Console.WriteLine();
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle
            Console.ReadKey();

            #endregion            
            Console.ReadLine();
        }
    }
}
