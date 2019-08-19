using System;
using System.Collections.Generic;
using System.Text;
using Example1.Example3.Models;

namespace Example1.Example3
{
    public class Rectangle : Shape
    {
        protected double side1;
        protected double side2;

        public double Side1 { get => side1; set => side1 = value; }
        public double Side2 { get => side2; set => side2 = value; }
        public void SetRectangle()
        {
            C.X = Side1;
            C.Y = Side2;
        }
    }
}
