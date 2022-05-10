using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStatic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compute c1 = new Compute(12, 45);
            Console.WriteLine("Antal objekter: " + Compute.numberOfObjects);
            Compute c2 = new Compute(11, 5);
            Console.WriteLine("Antal objekter: " + Compute.numberOfObjects);
            Compute c3 = new Compute(2, 22);
            Console.WriteLine("Antal objekter: " + Compute.numberOfObjects);
            Compute c4 = new Compute(112, 55);
            Console.WriteLine("Antal objekter: " + Compute.numberOfObjects);

            Console.WriteLine("12 + 45 = " + c4.GetSum());
            Console.WriteLine("12 + 45 = " + Compute.GetSum(12,45));

            Compute c5 = new Compute(34, 34);
            Console.WriteLine("Antal objekter: " + Compute.numberOfObjects);

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine(c5);            


            Console.ReadLine();

        }
    }
}
