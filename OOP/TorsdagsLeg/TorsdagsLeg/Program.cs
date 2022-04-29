using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorsdagsLeg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Ingen argumenter");
            }
            else
            {
                Console.WriteLine("Argumenter:");
                foreach (string arg in args)
                {
                    Console.WriteLine(arg);
                }
            }

            sbyte b1 = sbyte.MaxValue; // +127
            Console.WriteLine("b1: " + b1);
            //b1 = (sbyte)(b1 + 1); //b1++;
            b1 += 1;
            Console.WriteLine("b1: " + b1);

            int tal = int.MaxValue;
            Console.WriteLine("Max int: " + tal);
            tal++;
            Console.WriteLine("Max int + 1: " + tal);
            Console.ReadLine(); 
        }
    }
}
