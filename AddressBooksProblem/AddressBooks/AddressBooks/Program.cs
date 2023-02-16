﻿using System;
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
                Console.WriteLine("Select 1: for creating Contact, \nSelect 2: Edit Contact, \n Select 3: Delete contact ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        addressBooks.CreateContact();
                        addressBooks.Display();
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Edit the Contact");
                        addressBooks.EditDetails("Prince");
                        addressBooks.Display();
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Delete the Contact");
                        addressBooks.DeleteContact("Prince");
                        addressBooks.Display();
                        Console.ReadLine();
                        break;  
                    case 4:
                        flag = false;
                        break;
                }
            }
           
        }
    }
}
