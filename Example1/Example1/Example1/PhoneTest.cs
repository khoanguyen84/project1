using System;
using System.Collections.Generic;
using System.Text;
using Example1.Example6;
using Example1.Example6.Models;

namespace Example1
{
    public class PhoneTest
    {
        public static PhoneBook phoneBook = new PhoneBook();
        public static void Main()
        {
            InitMenu();
        }

        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("PHONE BOOK MANAGEMENT SYSTEM");
                Console.WriteLine("1. Insert Phone");
                Console.WriteLine("2. Remove Phone");
                Console.WriteLine("3. Update Phone");
                Console.WriteLine("4. Search Phone");
                Console.WriteLine("5. Sort");
                Console.WriteLine("6. Display");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Please select an option from 1 to 6");
                Console.Write("Option: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option > 7 || option <= 0);

            Process(option);
        }

        public static void Process(int selected)
        {
            Console.Clear();
            switch (selected)
            {
                case 1:
                    {
                        Console.WriteLine("Insert Phone ....");
                        Console.Write("Input name: ");
                        var name = Console.ReadLine();

                        Console.Write("Input phone number: ");
                        var phone = Console.ReadLine();

                        phoneBook.InsertPhone(name, phone);

                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Remove Phone ....");
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Update Phone ....");
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Search Phone ....");
                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Sort ....");
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("PHONE BOOK LIST");
                        Display();
                        break;
                    }
                case 7:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            InitMenu();
        }

        public static void Display()
        {
            Console.WriteLine("Name\t\t\tPhonenumer");
            if(phoneBook.PhoneList != null && phoneBook.PhoneList.Count > 0)
            {
                foreach(PhoneItem phoneItem in phoneBook.PhoneList)
                {
                    Console.WriteLine("{0}\t\t\t{1}", phoneItem.Name, phoneItem.PhoneNumber);
                }
            }
        }
    }
}
