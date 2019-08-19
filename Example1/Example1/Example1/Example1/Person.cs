using System;
using System.Collections.Generic;
using System.Text;

namespace Example1.Example1
{
    public class Person
    {
        private int age;
        public void SetAge(int n)
        {
            age = n;
        }
        public int GetAge()
        {
            return age;
        }

        public virtual void Greet()
        {
            Console.WriteLine("Peron say hello");
        }
    }
}
