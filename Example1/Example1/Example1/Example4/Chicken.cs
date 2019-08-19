using System;
using System.Collections.Generic;
using System.Text;

namespace Example1.Example4
{
    public class Chicken : Animal, IEdible
    {
        public override string MakeSound()
        {
            return "chip chip";
        }

        public string HowToEat()
        {
            return "rice";
        }

    }
}
