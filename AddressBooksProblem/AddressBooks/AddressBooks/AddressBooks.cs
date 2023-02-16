using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBooks
{
    public class AddressBooks
    {
        CreateContact contact = new CreateContact();

        List<CreateContact> contactList = new List<CreateContact>();

        public void CreateContact()
        {
            Console.WriteLine("Enter the First Name");
            contact.FirstName = Console.ReadLine();

            Console.WriteLine("Enter the Last Name");
            contact.LastName = Console.ReadLine();

            Console.WriteLine("Enter the Email");
            contact.Email = Console.ReadLine();

            Console.WriteLine("Enter the City");
            contact.City = Console.ReadLine();

            Console.WriteLine("Enter the Phone Number");
            contact.PhoneNumber = Console.ReadLine();

            Console.WriteLine("Enter the Address");
            contact.Address = Console.ReadLine();

            Console.WriteLine("Enter the State");
            contact.State = Console.ReadLine();

            Console.WriteLine("Enter the Zip");
            contact.Zip = Convert.ToInt64(Console.ReadLine());

            contactList.Add(contact);
        }
        public void Display()
        {
            Console.WriteLine("Contact Datails" + "\nFirstName"+ contact.FirstName + "\nLastName"+ contact.LastName+"\nEmail"+ contact.Email+
                "\nCity"+ contact.City+ "\nPhoneNumber"+ contact.PhoneNumber+ "\nAdress"+ contact.Address+ "\nState"+contact.State +"\nZip"+ contact.Zip);
        }

        public void EditDetails(string name)
        {
            foreach (var contact in contactList)
            {
                if (contact.FirstName.Equals(name))
                {
                    Console.WriteLine("1. Address, \n1 FirstName, \n2 Lastname, \n3 Email, \n4 City, \n5 PhoneNumber, \n6 Address, \n7 State, \n8 Zip ");
                    Console.WriteLine("1.Address");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the new First Name");
                            contact.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter the Last Name");
                            contact.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter the Email");
                            contact.Email = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter the City");
                            contact.City = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter the phone Number");
                            contact.PhoneNumber = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter the Address");
                            contact.Address = Console.ReadLine();
                            break;  
                        case 7:
                            Console.WriteLine("Enter the State ");
                            contact.State = Console.ReadLine();
                            break;
                        case 8:
                            Console.WriteLine("Enter the Zip");
                            contact.Zip = Convert.ToInt64(Console.ReadLine());
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Contact not found");
                }

            }
        }

        public void DeleteContact(string name)
        {
            CreateContact deleteContact = new CreateContact();
            foreach (var contact in contactList)
            {
                if (contact.FirstName.Equals(name))
                {
                    deleteContact = contact;
                }
                contactList.Remove(deleteContact);
            }
        }
    }
}
