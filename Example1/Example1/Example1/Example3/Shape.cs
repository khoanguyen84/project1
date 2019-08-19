using System;
using System.Collections.Generic;
using System.Text;
using Example1.Example3.Models;

namespace Example1.Example3
{
    public class Shape
    {
        protected Location c = new Location();

        public Location C { get => c; set => c = value; }

        public string toString(bool type)
        {
            return type ? "Area is: " + Area() : "Primeter is: " + Primeter();
        }
        
        public virtual double Area()
        {
            return c.X * c.Y;
        }
        public virtual double Primeter()
        {
            return (c.X + c.Y) * 2;
        }
    }
}
