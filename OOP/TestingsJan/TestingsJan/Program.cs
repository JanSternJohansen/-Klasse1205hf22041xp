using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestingsJan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Type D = typeof(Dog);
            MemberInfo[] members = D.GetMembers();
            foreach (MemberInfo m in members)
                Console.WriteLine(m);

            Dog[] dogs = new Dog[5];
            dogs[0] = new Dog("Bull", 12, 45);
            dogs[1] = new Dog("Lady", 2, 3);
            dogs[2] = new Dog("Snuffy", 1, 7);
            dogs[3] = new Dog("Lassie", 5, 9);
            dogs[4] = new Dog("Mopse", 15, 5);

            Console.WriteLine("\nUnsorted dogs:");
            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog);
            }

            Array.Sort(dogs, new MyCompare(SortType.Weight));

            Console.WriteLine("\nSorted dogs:");
            foreach (Dog dog in dogs)
            {
                Console.WriteLine(dog);
            }

            Dog d1 = new Dog("MyDog", 23, 34);
            Dog d2 = (Dog)d1.Clone();
            d2.Name = "YouDog";

            Console.WriteLine("\nOther dogs:");
            Console.WriteLine(d1);
            Console.WriteLine(d2);


            Console.ReadLine();
        }
    }
}
