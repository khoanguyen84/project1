using System;
using System.Collections.Generic;
using System.Text;

namespace Example1
{
    public class SortedList
    {
        public static void Main()
        {
            //SortedList<string, string> EmployeeList = new SortedList<string, string>();

            Dictionary<string, string> EmployeeList = new Dictionary<string, string>();

            //Add item
            EmployeeList.Add("Khoa", "Co tuong");
            EmployeeList.Add("Loc", "Co vua");
            EmployeeList.Add("Bao", "Karaoke");

            //show all by values
            Console.WriteLine("Show all values");
            foreach (var item in EmployeeList.Values)
            {
                Console.WriteLine(item);
            }

            //show all by keys
            Console.WriteLine("Show all keys");
            foreach (var key in EmployeeList.Keys)
            {
                Console.WriteLine(key);
            }

            //show all values by key
            Console.WriteLine("Show all keys");
            foreach (var key in EmployeeList.Keys)
            {
                Console.WriteLine("Key : {0} Value : {1}", key, EmployeeList[key]);
            }

            //Remove item by key
            Console.WriteLine("----------------------------");
            EmployeeList.Remove("Khoa");

            //foreach (var key in EmployeeList.Keys)
            //{
            //    Console.WriteLine("Key : {0} Value : {1}", key, EmployeeList[key]);
            //}

            ////Remove item by key and return value
            Console.WriteLine("----------------------------");
            string locValue;
            EmployeeList.Remove("Loc", out locValue);
            Console.WriteLine(locValue);
            //foreach (var key in EmployeeList.Keys)
            //{
            //    Console.WriteLine("Key : {0} Value : {1}", key, EmployeeList[key]);
            //}


            ////Remove item by index
            //Console.WriteLine("----------------------------");
            //EmployeeList.RemoveAt(0);
            //foreach (var key in EmployeeList.Keys)
            //{
            //    Console.WriteLine("Key : {0} Value : {1}", key, EmployeeList[key]);
            //}

            //show all value by using enumnator
            Console.WriteLine("----------------------------");
            var enumerator = EmployeeList.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine("Key : {0} Value : {1}", 
                                enumerator.Current.Key, enumerator.Current.Value);
            }

        }
    }
}