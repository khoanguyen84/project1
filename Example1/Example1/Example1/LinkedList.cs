using System;
using System.Collections.Generic;
using System.Text;

namespace Example1
{
    public class LinkedList
    {
        public static void Main()
        {
            LinkedList<string> Relationship = new LinkedList<string>();

            Relationship.AddFirst("Khoa");
            
            var phong = Relationship.First;
            Relationship.AddAfter(phong, "Phong");

            var tu = Relationship.Find("Phong");
            Relationship.AddAfter(tu, "Tu");

            var findPhong = Relationship.Find("Phong");
            Relationship.AddAfter(findPhong, "Loc");


            foreach(var rel in Relationship)
            {
                Console.WriteLine("item : {0}", rel);
            }
        }
    }
}
