﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFPDay10
{
    internal class MultipleAddressBook
    {
        
        Dictionary<string, List<Contact>> MultiDict = new Dictionary<string, List<Contact>>();
        public void DictionaryContacts()
        {
            AddressBook ObjAdd = new AddressBook();
            Console.WriteLine("How many ADDRESSBOOK, You want to create ");
            int BookNum = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= BookNum; i++)
            {
                Console.WriteLine("How many contcts you want to add in Addressbook ");
                int ContactNum = Convert.ToInt32(Console.ReadLine());
                for (int j = 1; j <= ContactNum; j++)
                {
                    ObjAdd.AddNewContact();
                }
                Console.WriteLine("What name you want to give to address book");
                string Bookname = Console.ReadLine();
                MultiDict.Add(Bookname, ObjAdd.ContactBook);
            }
            Console.WriteLine("AddressBook added successfully");
        }
    }
}
