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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Select 1: for creating Contact, \nSelect 2: Edit Contact, \nSelect 3: Delete contact, \nSelect 4: Display the Conatct ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        addressBooks.CreateContact();
                        //addressBooks.Display();
                        break;
                    case 2:
                        Console.WriteLine("Edit the Contact");
                        addressBooks.EditDetails("Prince");
                        //addressBooks.Display();
                        break;
                    case 3:
                        Console.WriteLine("Delete the Contact");
                        addressBooks.DeleteContact();
                        //addressBooks.Display();
                        break;
                    case 4:
                        Console.WriteLine("Display the Contact");
                        addressBooks.Display();
                        Console.ReadLine();
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
           
        }
    }
}
