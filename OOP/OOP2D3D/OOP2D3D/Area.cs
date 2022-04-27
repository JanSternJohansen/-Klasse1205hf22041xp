

using System;

namespace OOP2D3D
{
    public class Area
    {   
        // Fields
        private string _name;
        private int _length;
        private int _width;

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


    }
}
