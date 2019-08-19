using BaiTap5.Models;
using System;
using System.Collections.Generic;

namespace BaiTap5.DAL
{
    public class CustomerService : ICustomerService
    {
        public List<Customer> Customers = new List<Customer>();
        public void Add(Customer request)
        {
            Customers.Add(request);
        }

        public bool Delete(Customer request)
        {
            throw new NotImplementedException();
        }

        public Customer Get(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Customer> Gets()
        {
            return Customers;
        }

        public bool Update(Customer request)
        {
            throw new NotImplementedException();
        }
    }
}
