using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Punkt p1 = new Punkt(3, 7);
            Punkt p2 = new Punkt(6, 5);
      
            Punkt p3 = p1.Add(p2);

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            
            Console.WriteLine();
            Console.WriteLine("P1: " + p1);

            Punkt p4 = p1;
            Console.WriteLine("P4: " + p4);

            p1.X = 44;

            Console.WriteLine("P1: " + p1);
            Console.WriteLine("P4: " + p4);
            //////////////////////////////////////
            ///
            p4 = (Punkt)p1.Clone();
            Console.WriteLine("\nP1: " + p1);
            Console.WriteLine("P4: " + p4);
            p4.X = 7;
            p4.Y = 13;
            Console.WriteLine("P1: " + p1);
            Console.WriteLine("P4: " + p4);




            Console.ReadLine();
        }
    }
}
