using Example1.Example8;
using System;
using System.Collections.Generic;
using System.Text;

namespace Example1
{
    public class UserTest
    {
        public static Dictionary<int, User> UserList = new Dictionary<int, User>();
        public static int Id = 0;
        public static void Main()
        {
            InitMenu();
        }
        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("USER MANAGEMENT SYSTEM");
                Console.WriteLine("Please select an option from 1 to 4");
                Console.WriteLine("1. Add user");
                Console.WriteLine("2. Check user");
                Console.WriteLine("3. Display all users");
                Console.WriteLine("4. Exit");

                Console.Write("Option: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option > 4 || option <= 0);

            Process(option);
        }
        public static void Process(int selected)
        {
            Console.Clear();
            switch (selected)
            {
                case 1:
                    {
                        CreateUser();
                        break;
                    }
                case 2:
                    {
                        CheckUser();
                        break;
                    }
                case 3:
                    {
                        Display();
                        break;
                    }
                case 4:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            InitMenu();
        }
        public static void CreateUser()
        {
            var user = new User();
            Id = Id + 1;
            user.Id = Id;

            Console.Write("Please input user name: ");
            user.Name = Console.ReadLine();

            Console.Write("Please input passsword: ");
            user.Password = Console.ReadLine();

            Console.Write("Do you want add phone number: ");
            var addPhone = Console.ReadLine();
            if(string.Compare(addPhone.ToUpper(), "Y") == 0)
            {
                Console.Write("Please input phone number: ");
                user.PhoneList.Add(int.Parse(Console.ReadLine()));
            }

            UserList.Add(user.Id, user);
        }

        public static void CheckUser()
        {
            Console.Write("Please input user name: ");
            var name = Console.ReadLine();

            Console.Write("Please input passsword: ");
            var password = Console.ReadLine();

            var isExits = false;
            foreach (KeyValuePair<int, User> item in UserList)
            {
                if(item.Value.Name == name && item.Value.Password == password)
                {
                    isExits = true;
                    break;
                }
            }
            if (isExits)
            {
                Console.WriteLine("User checked");
            }
            else
            {
                Console.WriteLine("User not found");
            }
        }

        public static void Display()
        {
            foreach (KeyValuePair<int, User> item in UserList)
            {
                Console.WriteLine(item.Value.Info());
            }
        }
    }
}
