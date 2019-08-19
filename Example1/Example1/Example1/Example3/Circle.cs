using System;
using System.Collections.Generic;
using System.Text;
using Example1.Example3.Models;

namespace Example1.Example3
{
    public class Circle : Shape
    {
        private double radius;
        private const double pi = Math.PI;

        public double Radius { get => radius; set => radius = value; }

        public override double Area()
        {
            return Radius * Radius * pi;
        }

        public override double Primeter()
        {
            return 2 * Radius * pi;
        }

    }
}
