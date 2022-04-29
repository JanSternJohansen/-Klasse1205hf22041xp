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
            a1.Color = MyColorEnum.Blue;
            a1.setName("BoBo");
            Console.WriteLine(a1.getName());

            a1.Length = 20;
            int len = a1.Length;
            a1.Width = 12;
            Console.WriteLine($"{ a1.getName()}  L: { a1.Length}  W: { a1.Width}");

            Console.WriteLine(a1.ToString());

            Area a2 = new Area();
            a2.setName("Oliver");
            a2.Length = 3;
            a2.Width = 13;
            Console.WriteLine(a2);

            Area a3 = new Area(MyColorEnum.Red,"Subarna", 16, 77);
            Console.WriteLine(a3);

            Area[] areas = new Area[5];
            areas[0] = a1;
            areas[1] = a2;
            areas[2] = a3;
            areas[3] = new Area(MyColorEnum.Cyan, "Hansen", 3, 4);
            areas[4] = new Area(MyColorEnum.Green, "Babuska", 456, 567);

            Console.WriteLine("Unsorted:");
            foreach (Area a in areas)
                Console.WriteLine(a);

            Array.Sort(areas);

            Console.WriteLine("Sorted:");
            foreach (Area a in areas)
                Console.WriteLine(a);

            /////////////////////////////////////////////////
            /// Cubic
            /// 
            Console.WriteLine("\nNow comes Cubics");
            Cubic c1 = new Cubic();
            c1.setName("Marko");
            c1.Height = 23;
            c1.Width = 12;
            c1.Length = 7;
            Cubic c2 = new Cubic();
            c2.setName("Marko");
            c2.Height = 3423;
            c2.Width = 12;
            c2.Length = 7;

            Object[] objects = new object[8];
            objects[0] = c1;
            objects[1] = a1;
            objects[2] = c2;
            objects[3] = a2;
            objects[4] = a3;
            objects[5] = new Cubic(MyColorEnum.Yellow, "Visar", 23, 45, 8);
            objects[6] = new Area(MyColorEnum.Magenta, "Joshi", 3, 4);
            objects[7] = new Cubic(MyColorEnum.Green, "@czsehl", 45, 75, 56);

            foreach(Object o in objects)
            {
                Console.WriteLine(o);
            }


            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());


            Console.ReadLine();

        }
    }
}
