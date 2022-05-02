using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingsJan
{
    internal class Dog : ICloneable
    {
        private string _name;
        private int _age;
        private int _weight;

        public int Weight { get => _weight; set => _weight = value; }
        public int Age { get => _age; set => _age = value; }
        public string Name { get => _name; set => _name = value; }

        //public void set_Name(String n) { this._name = n; }

        public Dog(string n, int a, int w)
        {
            Name = n;
            Age = a;
            Weight = w;
        }

        public Dog()
        {
        }

        public override string ToString()
        {
            return string.Format("{0, -8}  Age: {1, 3}  Weight: {2, 3}", Name, Age, Weight);
        }

        public object Clone()
        {
            Dog dog = new Dog()
            {
                Name = Name,
                Age = Age,
                Weight = Weight

            };
            return dog;
        }
    }
}
