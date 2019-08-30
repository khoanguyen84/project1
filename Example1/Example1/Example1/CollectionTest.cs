using System;
using System.Collections.Generic;
using System.Text;

namespace Example1
{
    public class CollectionTest
    {
        public static void Main()
        {
            SortedList<string, string> EmployeeList = new SortedList<string, string>();
            EmployeeList.Add("Khoa", "Giao vien");
            EmployeeList.Add("Loc", "Lap Trinh Vien");
            EmployeeList.Add("Thanh", "Leader");
            EmployeeList.Add("Bao", "Marketing");

            Console.WriteLine("GetKey()");
            Console.WriteLine("Key : {0}", EmployeeList.Keys[3]);

            Console.WriteLine("GetByIndex()");
            Console.WriteLine("Index : {0}", EmployeeList.IndexOfKey("Khoa"));

            Console.WriteLine("Show all keys");
            foreach (var key in EmployeeList.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("Show all values");
            foreach (var value in EmployeeList.Values)
            {
                Console.WriteLine(value);
            }

            Stack<int> BookStack = new Stack<int>();
            BookStack.Push(123);
            BookStack.Push(456);

        }
    }
}
