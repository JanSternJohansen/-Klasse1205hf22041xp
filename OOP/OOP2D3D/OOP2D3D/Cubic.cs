using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2D3D
{
    internal class Cubic : Area
    {
        private int _height;
        public int Height 
        { 
            get { return _height; }
            set { _height = value; }
        }

        public Cubic() { }
        public Cubic(MyColorEnum col, String name, int length, int width, int height) 
            : base(col, name, length, width) // Areas constructor
        {
            //this.Color = col;
            //this.setName(name);
            //this.Length = length;
            //this.Width = width;
            this.Height = height;
        }
        public override string ToString()
        {
            return String.Format(base.ToString() + " Height: {0, 4} ", this.Height);
        }
        public override int GetSize()
        {
            return base.GetSize() * Height;
            //return Length * Width * Height;
        }
    }
}
