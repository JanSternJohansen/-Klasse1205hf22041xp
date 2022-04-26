using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Root2_12 = 1.0594630945;//1,0594630943593
            double ShouldBe2 = Math.Pow(Root2_12, 12 );
            Console.WriteLine("Skulle blive 2: " + ShouldBe2);
            

            double r = Math.Pow(2, (1.0 / 12));
            Console.WriteLine(r);

            double r2 = Math.Pow(10,Math.Log10(2) / 12);
            Console.WriteLine(r2);

            //Console.Beep(1000, 1000);

            double tone = 500;
            int[] tones = new int[13];
            for (int i = 0; i < tones.Length; i++)
            {
                tones[i] = (int)tone;
                tone = tone * r;
                //Console.Beep(tones[i], 100);
            }

            Console.Beep(tones[0], 400);
            Console.Beep(tones[0], 400);
            Console.Beep(tones[0], 400);
            Console.Beep(tones[2], 400);
            Console.Beep(tones[4], 400);
            Console.Beep(tones[4], 400);
            Console.Beep(tones[4], 600);
            Console.Beep(tones[2], 400);
            Console.Beep(tones[2], 400);
            Console.Beep(tones[2], 400);
            Console.Beep(tones[4], 600);
            Console.Beep(tones[0], 700);
            Console.Beep(tones[0], 1000);
           






            Console.ReadLine();
        }
    }
}
