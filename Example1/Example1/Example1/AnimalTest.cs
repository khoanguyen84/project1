using System;
using System.Collections.Generic;
using System.Text;
using Example1.Example4;

namespace Example1
{
    public class AnimalTest
    {
        public static void Main()
        {
            Console.WriteLine("*************Chicken*****************");
            var chip = new Chicken();
            Console.WriteLine("Chip says: {0}", chip.MakeSound());
            Console.WriteLine("Chip eats: {0}", chip.HowToEat());

            Console.WriteLine("*************Tiger*****************");
            var purma = new Tiger();
            Console.WriteLine("Purma says: {0}", purma.MakeSound());

            Console.WriteLine("*************Apple*****************");
            var china = new Apple();
            Console.WriteLine(china.HowToEat());

            Console.WriteLine("*************Orange*****************");
            var sanh = new Orange();
            Console.WriteLine(sanh.HowToEat());

            Console.ReadKey();
        }

    }
}
