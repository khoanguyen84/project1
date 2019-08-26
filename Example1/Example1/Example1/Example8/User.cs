using System;
using System.Collections.Generic;
using System.Text;

namespace Example1.Example8
{
    public class User : IUser
    {
        protected int id;
        protected string name;
        protected string password;
        public List<int?> PhoneList = new List<int?>();
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public string Password { get => password; set => password = value; }

        public string Info()
        {
            if (PhoneList == null || PhoneList.Count == 0)
                return $"Id: {id} Name: {name} Password: {password}";
            else
                return $"Id: {id} Name: {name} Password: {password} Phone list: {string.Join(" - ", PhoneList)}";
        }
    }
}
