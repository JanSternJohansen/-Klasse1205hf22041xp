

using System;

namespace OOP2D3D
{
    public class Area
    {
        // Fields
        private string _name;
        private int _length;
        private int _width;

        public Area() { }

        public Area(string name, int len, int wid)
        {
            this.setName(name);
            this.Length = len;
            this.Width = wid;   
        }

        // Properties
        public int Length 
        {
            get {return this._length; }
            set {this._length = value;} 
        }
        public int Width
        {
            get { return this._width; }
            set { this._width = value; }
        }

        // Metoder
        public void setName(String n)
        {
            if (n.Length > 2 && n.Length < 50)
            {
                this._name = n;
            }
            else
            {
                this._name = "N/A";
            }
        }
        public string getName()
        {
            return this._name;
        }

        public override string ToString()
        {
            return $"{ this.getName()}  L: { this.Length}  W: { this.Width}";
        }


    }
}
