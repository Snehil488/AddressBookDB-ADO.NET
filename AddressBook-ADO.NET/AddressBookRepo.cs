using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace AddressBook_ADO.NET
{
    class AddressBookRepo
    {
        public static string connectionString = @"Data Source=LAPTOP-T69UTPHB\SQLEXPRESS;Initial Catalog=AddressBookServiceDB;Integrated Security=True";
        SqlConnection connection = new SqlConnection(connectionString);
        public void GetAllContacts()
        {
            try
            {
                AddressBookModel adressbook = new AddressBookModel();
                using (this.connection)
                {
                    string query = @"Select * from AddressBook;";
                    SqlCommand cmd = new SqlCommand(query, this.connection);
                    this.connection.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            adressbook.FirstName = dr.GetString(0);
                            adressbook.LastName = dr.GetString(1);
                            adressbook.Address = dr.GetString(2);
                            adressbook.City = dr.GetString(3);
                            adressbook.State = dr.GetString(4);
                            adressbook.Zip = dr.GetInt32(5);
                            adressbook.PhoneNumber = dr.GetString(6);
                            adressbook.AddressbookName = dr.GetString(7);
                            adressbook.Type = dr.GetString(8);
                            System.Console.WriteLine(adressbook.FirstName + " " + adressbook.LastName + " " + adressbook.Address + " " + adressbook.City + " " + adressbook.PhoneNumber + " " + adressbook.Type);

                        }
                    }
                    else
                    {
                        System.Console.WriteLine("No data found");
                    }
                }
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
