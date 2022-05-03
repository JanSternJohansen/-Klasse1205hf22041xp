
using System;
using System.Collections;


namespace CarProject
{
    internal class CompareAll : IComparer
    {
        private string compType;
        public CompareAll(string compType)
        {
            this.compType = compType;
        }
        public int Compare(object car1, object car2)
        {
           if(compType == "Brand")
            {
               return ((Car)car1).Brand.CompareTo(((Car)car2).Brand);  // "A" < "B" // "Ab" < "Ac"
            }
           else if(compType == "TopSpeed")
            {
                return ((Car)car1).TopSpeed - ((Car)car2).TopSpeed;
            }
           else if(compType == "Accelerate")
            {
                return ((Car)car1).GetAcceleration().CompareTo(((Car)car2).GetAcceleration());
            }
           else // Default, hvis ingen rigtige er valgt
            {
                Console.WriteLine("No sorting");
                return 0; // sorteres ikke
            }
        }
    }
}
