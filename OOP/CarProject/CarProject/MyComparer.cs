using System;
using System.Collections;

namespace CarProject
{
    internal class MyCompare : IComparer
    {
        public int Compare(object car1, object car2)
        {
            //double result = ((Car)car1).GetAcceleration() - ((Car)car2).GetAcceleration();
            //if (result > 0)
            //    return 1;
            //else if (result < 0)
            //    return -1;
            //else
            //    return 0;

            // return ((Car)car1).TopSpeed - ((Car)car2).TopSpeed;

            return ((Car)car1).Brand.CompareTo(((Car)car2).Brand);


        }
    }
}