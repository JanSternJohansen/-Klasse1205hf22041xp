using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddProject
{
    public class Punkt : IAddable, ICloneable
    {
        private int _x;
        private int _y;

        public int X 
        { 
            get { return _x; } 
            set { this._x = value; } 
        }
        public int Y { get { return _y; } set { this._y = value; } }

        public Punkt() { }
        public Punkt(int x, int y) { this.X = x; this.Y = y; }

        public override string ToString()
        {
            return string.Format("X: {0}  Y: {1}", X, Y);
        }

        public Punkt Add(Punkt p)
        {
            Punkt pNew = new Punkt();
            pNew.X = this.X + p.X;
            pNew.Y = this.Y + p.Y;

            return pNew;
        }

        public object Clone()
        {
            Punkt newP = new Punkt();
            newP.X = this.X;
            newP.Y = this.Y;
            return newP;
        }
    }
}
