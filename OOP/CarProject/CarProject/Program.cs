using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.Brand = "Ford";
            c1.Model = "Ka";
            c1.Color = EnumColor.MingBlue;
            c1.TopSpeed = 380;
            c1.Weight = 200;
            c1.HorseP = 4;

            Car c2 = new Car("Opel", "Corsa", EnumColor.White);
            c2.TopSpeed = 180;
            c2.Weight = 560;
            c2.HorseP = 234;

            Car c3 = new Car("Renault", "Salisman", EnumColor.Silver, 127, 1000, 450);
           

            // Object initializing
            Car c4 = new Car()
            {
                Brand = "Peugeot",
                Model = "305",
                Color = EnumColor.Orange,
                TopSpeed = 200,
                Weight = 1200,
                HorseP = 230
            };

            Car[] cars = new Car[5];
            cars[0] = c1;
            cars[1] = c2;
            cars[2] = c3;
            cars[3] = c4;
            cars[4] = new Car("Suzuki", "Swift", EnumColor.Blue, 167, 6000, 50);

            Console.WriteLine("Unsorted Cars:");
            foreach (Car c in cars)
            {
                Console.WriteLine(c);
            }

            MyCompare mc = new MyCompare();
            int result = mc.Compare(cars[2], cars[3]);

            Array.Sort(cars, new MyCompare());
            Console.WriteLine("\nSorted Cars:");
            foreach (Car c in cars)
            {
                Console.WriteLine(c);
            }


            Console.ReadLine();

        }
    }
}
