using Domain;
using System;
using System.Collections.Generic;

namespace BAL.Interface
{
    public interface IUserService
    {
        bool AddUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int userId);
        IList<User> GetAllUser();
        User GetUserById(int userId);
    }
}
