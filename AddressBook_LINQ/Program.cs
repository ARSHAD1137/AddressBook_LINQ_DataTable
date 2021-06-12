using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Address Book");
            Linq_DataTable linqToDataTable = new Linq_DataTable();
            Linq_DataTable.AddToDataTableDemo();
            Linq_DataTable.DisplayAddressBook();
            Console.ReadKey();
        }
    }
}
