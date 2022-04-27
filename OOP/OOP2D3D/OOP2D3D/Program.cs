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

            a1.setName("BooooooooooooooooooooooooooooooooooooBooooooooooooooooooooooooooooooooooo");
            Console.WriteLine(a1.getName());

            Console.ReadLine();

        }
    }
}
