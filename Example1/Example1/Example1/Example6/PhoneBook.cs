using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Example1.Example6.Models;

namespace Example1.Example6
{
    public class PhoneBook : Phone
    {
        public ArrayList PhoneList = new ArrayList();
        public override void InsertPhone(string name, string phone)
        {
            if (PhoneList != null && UserIsExited(name))
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.Name == name)
                    {
                        if(phoneItem.PhoneNumber != phone)
                        {
                            phoneItem.PhoneNumber += ":" + phone;
                        }
                    }
                }
            }
            else
            {
                var phoneItem = new PhoneItem();
                phoneItem.Name = name;
                phoneItem.PhoneNumber = phone;
                PhoneList.Add(phoneItem);
            }
        }
        public override void RemovePhone(string name)
        {
            if (PhoneList != null)
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.Name == name)
                    {
                        PhoneList.Remove(phoneItem);
                    }
                }
            }
        }
        public override void UpdatePhone(string name, string newPhone)
        {
            if (PhoneList != null)
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.Name == name)
                    {
                        phoneItem.PhoneNumber = newPhone;
                    }
                }
            }
        }
        public override void SearchPhone(string name)
        {
            if (PhoneList != null)
            {
                foreach (PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.Name == name)
                    {
                        Console.WriteLine("Phonenumber's {0} is {1}.", name, phoneItem.PhoneNumber);
                        break;
                    }
                }
            }
        }
        public override void Sort()
        {
            IComparer comparer = new Comparer();
            PhoneList.Sort(comparer);
        }

        private bool UserIsExited(string userName)
        {
            if(PhoneList != null)
            {
                foreach(PhoneItem phoneItem in PhoneList)
                {
                    if (phoneItem.Name == userName)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
    public class Comparer : IComparer
    {
        public int Compare(object x, object y)
        {
            return ((new CaseInsensitiveComparer()).Compare(((PhoneItem)x).Name, ((PhoneItem)y).Name));
        }
    }
}
