using System;
using System.Collections.Generic;
using System.Text;

namespace Example1
{
    public class List
    {
        public static void Main()
        {
            List<Dictionary<int, Member>> C6 = new List<Dictionary<int, Member>>();
            var to1 = new Dictionary<int, Member>();
            to1.Add(1, new Member() {
                DOB = "1/1/2000",
                FullName = "Khoa Nguyen"
            });
            to1.Add(2, new Member()
            {
                DOB = "1/12/2000",
                FullName = "Bao Nguyen"
            });

            C6.Add(to1);
            
            foreach (var to in C6)
            {
                foreach (var member in to)
                {
                    Console.WriteLine("Id: {0}, Full Name: {1}, DOB: {2}", 
                            member.Key, member.Value.FullName, member.Value.DOB);
                }

            }

            var result = Fibo(5);
            Console.WriteLine(result);
        }

        public static long Fibo(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            else
                return Fibo(n - 1) + Fibo(n - 2);
        }
    }

    public class Member
    {
        public string FullName { get; set; }
        public string DOB { get; set; }
    }

}
