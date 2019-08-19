using System;
using System.Collections.Generic;
using System.Text;
using Example1.Example3;

namespace Example1
{
    public class ShapeTest
    {
        public static void Main()
        {
            var rect = new Rectangle();
            rect.Side1 = 5.5;
            rect.Side2 = 7.5;
            rect.SetRectangle();
            Console.WriteLine(rect.toString(true));
            Console.WriteLine(rect.toString(false));


            var cir = new Circle();
            cir.Radius = 10;
            Console.WriteLine(cir.toString(true));
            Console.WriteLine(cir.toString(false));
        }
    }
}
