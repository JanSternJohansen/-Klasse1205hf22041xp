using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2D3D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Area a1 = new Area();
            //a1.width = -20;
            //a1.length = 7;
            //a1.name = "Torben";

            a1.setName("BoBo");
            Console.WriteLine(a1.getName());

            a1.Length = 20;
            int len = a1.Length;
            a1.Width = 12;
            Console.WriteLine($"{ a1.getName()}  L: { a1.Length}  W: { a1.Width}");

            Console.WriteLine(a1.ToString());

            Area a2 = new Area();
            a2.setName("Oliver");
            a2.Length = 34;
            a2.Width = 13;
            Console.WriteLine(a2);

            Area a3 = new Area("Subarna", 16, 7);
            Console.WriteLine(a3);


            Console.ReadLine();

        }
    }
}
