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

            //Array.Sort(cars); // Forventer at Car har implementeret IComparable, som har metoden CompareTo()


            MyCompareBrand compBrand = new MyCompareBrand();
            int result = compBrand.Compare(cars[2], cars[3]);

            Array.Sort(cars, compBrand);
            Console.WriteLine("\nSorted Cars on Brand:");
            foreach (Car c in cars)
            {
                Console.WriteLine(c);
            }

            MyCompareAcceleration compAcc = new MyCompareAcceleration();
            Array.Sort(cars, compAcc);
            Console.WriteLine("\nSorted Cars on Acceleration:");
            foreach (Car c in cars)
            {
                Console.WriteLine(c);
            }

            MyCompareTopSpeed compTopSpeed = new MyCompareTopSpeed();
            Array.Sort(cars, compTopSpeed);
            Console.WriteLine("\nSorted Cars on TopSpeed:");
            foreach (Car c in cars)
            {
                Console.WriteLine(c);
            }


            //MyComparer mc = new MyComparer("C");
            //Array.Sort(cars, mc);

            //MyComparer mc = new MyComparer("T");
            //Array.Sort(cars, mc);

            //MyComparer mc = new MyComparer("A");
            //Array.Sort(cars, mc);



            Console.ReadLine();

        }
    }
}
