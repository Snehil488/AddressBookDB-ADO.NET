﻿using System;

namespace AddressBook_ADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddressBookRepo addressBook = new AddressBookRepo();
            addressBook.GetAllContacts();
        }
    }
}
