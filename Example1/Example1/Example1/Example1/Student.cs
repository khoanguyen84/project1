using System;
using System.Collections.Generic;
using System.Text;

namespace Example1.Example1
{
    public class Student : Person
    {
        public void GoToClasses()
        {
            Console.WriteLine("T'm going to class");
        }

        public void ShowAge()
        {
            Console.WriteLine("My age is: {0} year{1} old", GetAge(), GetAge() > 2 ? "s" : "");
        }
        public override void Greet()
        {
            Console.WriteLine("Student say hello");
        }
    }
}
