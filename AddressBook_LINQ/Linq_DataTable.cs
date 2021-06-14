using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace AddressBook_LINQ
{
    class Linq_DataTable
    {
        public void AddToDataTableDemo()
        {
            DataTable table = new DataTable();
            table.Columns.Add("FirstName", typeof(string));
            table.Columns.Add("LastName", typeof(string));
            table.Columns.Add("Address", typeof(string));
            table.Columns.Add("City", typeof(string));
            table.Columns.Add("State", typeof(string));
            table.Columns.Add("Zip", typeof(int));
            table.Columns.Add("PhoneNumber", typeof(int));
            table.Columns.Add("Email", typeof(string));

            table.Rows.Add("Rakesh", "Singh", "Hill Tower", "Mumbai", "Maharashtra", 414141, 9199199191, "rakesh@gmail.com");
            table.Rows.Add("Rahul", "Roy", "Street 20", "Mumbai", "Maharashtra", 411114, 9191919191, "rahul@outlook.com");
            table.Rows.Add("Akshay", "Singhal", "Lower street", "Pune", "Maharashtra", 414144, 8188181818, "akshay@gmail.com");
            table.Rows.Add("Nitin", "Bansal", "Street 49", "Noida", "Delhi", 411311, 818181818, "nitin@hotmail.com");

            DisplayAddressBook(table);
        }
        public void DisplayAddressBook(DataTable table)
        {
            var contacts = table.Rows.Cast<DataRow>();
            foreach (var contact in contacts)
            {
                Console.Write("First Name:" + contact.Field<string>("FirstName") + " " + "Last Name:" + contact.Field<string>("LastName") + " " + "Address:" + contact.Field<string>("Address") + " " + "City:" + contact.Field<string>("City") + " " + "State:" + contact.Field<string>("State")
                + " " + "Zip:" + contact.Field<int>("Zip") + " " + "Phone Number:" + contact.Field<int>("PhoneNumber") + " " + "Email:" + contact.Field<string>("Email") + " ");
            }
        }
    }
}
