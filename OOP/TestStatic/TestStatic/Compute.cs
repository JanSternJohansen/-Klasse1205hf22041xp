using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestStatic
{
    public class Compute
    {
        private int tal1;
        private int tal2;
        public static int numberOfObjects;
        public int MyId;
        public Compute(int t1, int t2)
        {
            numberOfObjects++;
            MyId = numberOfObjects;
            this.tal1 = t1;
            this.tal2 = t2;
        }
        public int GetSum()
        {
            //Fra non-static kan static kaldes
            //int tal = GetSum(3, 4);
            return this.tal1 + this.tal2;
        }
        public static int GetSum(int t1, int t2)
        {
            // Fra static kan non-static ikke kaldes
            //GetSum(); // error
            return t1 + t2;  
        }
        public override string ToString()
        {
            return "MyId: " + MyId;
        }
    }
}
