using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program ");
            AddressBooks addressBooks = new AddressBooks();
            addressBooks.CreateContact();
            addressBooks.Display();
        }
    }
}
