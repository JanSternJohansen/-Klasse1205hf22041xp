using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingsJan
{
    public enum SortType
    {
        Name, Age, Weight
    }

    internal class MyCompare : IComparer
    {
        private SortType sortT;

        public MyCompare(SortType sortT)
        {
            this.sortT = sortT;
        }

        public int Compare(object dog1, object dog2)
        {
            switch (sortT)
            {
                case SortType.Weight:
                    return ((Dog)dog1).Weight - ((Dog)dog2).Weight;
                case SortType.Age:
                    return ((Dog)dog1).Age - ((Dog)dog2).Age;
                case SortType.Name:
                    return ((Dog)dog1).Name.CompareTo(((Dog)dog2).Name);
                default:
                    return ((Dog)dog1).Name.CompareTo(((Dog)dog2).Name);
            }
        }
    }
}
