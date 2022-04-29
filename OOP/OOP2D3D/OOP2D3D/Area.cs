

using System;

namespace OOP2D3D
{
    public class Area : IComparable
    {
        // Fields
        private string _name;
        private int _length;
        private int _width;
        private MyColorEnum _color;
        
        // Constructors
        public Area() { }

        public Area(MyColorEnum col,string name, int len, int wid)
        {
            this.Color = col;
            this.setName(name);
            this.Length = len;
            this.Width = wid;   
        }

        // Properties
        public int Length 
        {
            get {return this._length; }
            set 
            {
                if(value > 0)
                {
                    this._length = value;
                }
                else
                {
                    this.Length = 0;
                }
            }
                
        }
        public int Width
        {
            get { return this._width; }
            set { this._width = value; }
        }
        public MyColorEnum Color
        {
            get { return this._color; }
            set { this._color = value; }
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

        public virtual int GetSize()
        {
            return this.Width * this.Length;
        }

        public override string ToString()
        {
            //return $"{ this.getName(), -8} Size: {this.GetSize()} L: { this.Length}  W: { this.Width}";
            return String.Format("Color {0, -8}  {1,-8} Size: {2, 6} Len: {3, 4} Wid: {4, 4}", this.Color, this.getName(), this.GetSize(), this.Length, this.Width);
        }

        // a1.CompareTo(a2);
        // returnere + når a1 er størst
        // returnere - når a2 er størst
        // returne 0 når a1 og a2 er lige store

        // int CompareTo(object obj);
        public int CompareTo(object obj)
        {
            //Area area = obj as Area;
            Area area = (Area)obj;
            return  + area.GetSize() - this.GetSize();
        }
    }
}
