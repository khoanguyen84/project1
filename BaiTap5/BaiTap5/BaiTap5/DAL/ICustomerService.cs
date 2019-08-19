using BaiTap5.Models;
using System.Collections.Generic;

namespace BaiTap5.DAL
{
    interface ICustomerService
    {
        bool Delete(Customer request);
        void Add(Customer request);
        bool Update(Customer request);
        Customer Get(int Id);
        List<Customer> Gets();
    }
}
