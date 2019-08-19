using System;
using BaiTap5.DAL;
using BaiTap5.Models;

namespace BaiTap5
{
    class Program
    {
        static void Main(string[] args)
        {
            var customerService = new CustomerService();

            Console.WriteLine("Manager customers");
            Console.WriteLine("***************************************************");
            Console.WriteLine("1. Create 5 customers:");
            for (int i = 0; i < 2; i++)
            {
                string fullName;
                string gender;
                Console.Write("Customer name input: ");
                fullName = Console.ReadLine();
                Console.Write("Customer gender input: ");
                gender = Console.ReadLine();
                var request = new Customer()
                {
                    Id = i,
                    Fullname = fullName,
                    Gender = gender,
                    Loyaly = 10
                };
                customerService.Add(request);
            }

            Console.WriteLine("***************************************************");
            Console.WriteLine("2. Show all customers");
            Console.WriteLine("{0}\t\t{1}\t\t\t{2}\t\t\t{3}", "Id", "Fullname", "Gender", "Loyaly");
            foreach (var customer in customerService.Gets())
            {
                Console.WriteLine("{0}\t\t{1}\t\t\t{2}\t\t\t{3}", customer.Id, customer.Fullname, customer.Gender, customer.Loyaly);
            }

            
            Console.ReadKey();
        }
    }
}
