using System;
using System.Collections.Generic;
using System.Text;

namespace Example1.Example1
{
    public class Teacher : Person
    {
        private string subject;
        public void Explain()
        {
            Console.WriteLine("Explaination begins");
        }
        public override void Greet()
        {
            base.Greet();
            Console.WriteLine("Teacher say hello");
        }
    }
}
