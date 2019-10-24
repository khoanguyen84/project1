using Domain;
using System;
using System.Collections.Generic;

namespace DAL.Interface
{
    public interface IUserRepository
    {
        int AddUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int userId);
        IList<UserView> GetAllUser();
        User GetUserById(int userId);
    }
}
