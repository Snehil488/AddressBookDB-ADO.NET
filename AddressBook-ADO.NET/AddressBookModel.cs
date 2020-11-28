using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_ADO.NET
{
    class AddressBookModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City  { get; set; }
        public string State  { get; set; }
        public string Type  { get; set; }
        public string AddressbookName  { get; set; }
        public string PhoneNumber { get; set; }
        public int Zip  { get; set; }
    }
}
