using  System;
using System.Collections.Generic;
using System.Text;
using Example1.Example1;

namespace Example1
{
    public class StudentAndTeacherTest
    {
        public static void Main()
        {
            var khoa = new Person();
            Console.WriteLine("**********Person class**********");
            khoa.Greet();

            Console.WriteLine("**********Student class**********");
            var bao = new Student();
            Console.Write("Input age's student: ");
            var number = Console.ReadLine();
            if(int.TryParse(number, out var outNumber))
            {
                bao.SetAge(outNumber);
                bao.Greet();
                bao.ShowAge();
            }
            else
            {
                Console.WriteLine("Invalid age");
            }
            

            Console.WriteLine("**********Teacher class**********");
            var loc = new Teacher();
            loc.SetAge(30);
            loc.Greet();
            loc.Explain();
        }
    }
}
