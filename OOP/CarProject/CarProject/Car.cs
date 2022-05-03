using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarProject
{ 
    public enum EnumColor
    {
        Red, Green, Blue, Black, White, Yellow, Orange, Pink, Silver, MingBlue
    }

    internal class Car
    {
        private string _brand;
        private string _model;
        private EnumColor _color;
        private int _topSpeed;
        private int _horseP;
        private int _weight;

        public string Brand 
        { 
            get => _brand; 
            set => _brand = value; 
        }

        //public string Brand2
        //{
        //    get { return _brand; }
         //   set { _brand = value; }
        //}
        public string Model { get => _model; set => _model = value; }
        public EnumColor Color { get => _color; set => _color = value; }
        public int TopSpeed { get => _topSpeed; set => _topSpeed = value; }
        public int HorseP { get => _horseP; set => _horseP = value; }
        public int Weight { get => _weight; set => _weight = value; }

        public Car() { }
        public Car(string brand, string model, EnumColor color) 
        {
            this.Brand = brand;
            this.Model = model;
            this.Color = color;
        }
        public Car(string brand, string model, EnumColor color, int topSpeed, int weight, int horsePower) 
            : this(brand, model, color)
        {
            //this.Brand = brand;
            //this.Model = model;
            //this.Color = color;

            this.TopSpeed = topSpeed;
            this.Weight = weight;
            this.HorseP = horsePower;
        }

        public double GetAcceleration()
        {
            return Weight / HorseP;
        }


        public override string ToString()
        {
            return String.Format("{0, -8}  {1, -8}  {2, -8}  {3, 4}  {4,4}  {5,-4}  {6,4}", Brand, Model, Color, TopSpeed, Weight, HorseP, GetAcceleration());
        }

    }
}
