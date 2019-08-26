using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Example1
{
    public class HashTableTest
    {
        public static void Main()
        {
            Console.WriteLine("Hash Table Example");
            Hashtable htPhone = new Hashtable();
            for(int i = 0; i<3; i++)
            {
                Console.Write("Inpput key: ");
                var key = Console.ReadLine();
                Console.Write("Iput Name: ");
                var name = Console.ReadLine();
                htPhone.Add(key, name) ;
            }

            Console.WriteLine("Show Hash table");
            foreach(var key in htPhone.Keys)
            {
                Console.WriteLine("Key: {0}, Name: {1}", key, htPhone[key]);
            }
        }
    }
}
