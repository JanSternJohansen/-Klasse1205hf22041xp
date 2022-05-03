
using System;
using System.Collections;


namespace CarProject
{
    internal class CompareAll : IComparer
    {
        private CarSortEnum compType;
        public CompareAll(CarSortEnum compType)
        {
            this.compType = compType;
        }
        public int Compare(object car1, object car2)
        {
            switch(compType)
            {
                case CarSortEnum.Brand:
                    return ((Car)car1).Brand.CompareTo(((Car)car2).Brand);
                    
                case CarSortEnum.TopSpeed:           
                    return ((Car)car1).TopSpeed - ((Car)car2).TopSpeed;
                   
                case CarSortEnum.Accelerate:
                    return ((Car)car1).GetAcceleration().CompareTo(((Car)car2).GetAcceleration());
                    
                default:
                return 0;
            }
        }
    }
}
