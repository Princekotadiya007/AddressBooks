﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBooks
{
    public class AddressBooks
    {
        CreateContact contact = new CreateContact();

        List<CreateContact> contactList = new List<CreateContact>();

        Dictionary<string, CreateContact> addressBookDictionry = new Dictionary<string, CreateContact>();
        Dictionary<string, List<CreateContact>> addressBookCity = new Dictionary<string, List<CreateContact>>();

        //string AddressContact = "D:\\RFP-demo\\AddressBooks\\AddressBooksProblem\\AddressBooks\\AddressBooks\\AddressBookContact\\AddressContact.txt";


        public void CreateContact()
        {
            CreateContact contact = new CreateContact();
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
            foreach (var contact in contactList)

                Console.WriteLine("Contact Datails" + "\nFirstName" + contact.FirstName + "\nLastName" + contact.LastName + "\nEmail" + contact.Email +
                    "\nCity" + contact.City + "\nPhoneNumber" + contact.PhoneNumber + "\nAdress" + contact.Address + "\nState" + contact.State + "\nZip" + contact.Zip);
        }

        public void EditDetails(string name)
        {
            foreach (var contact in addressBookDictionry)
            {
                if (contact.Key.Equals(name))
                {
                    Console.WriteLine("1. Address, \n1 FirstName, \n2 Lastname, \n3 Email, \n4 City, \n5 PhoneNumber, \n6 Address, \n7 State, \n8 Zip ");
                    Console.WriteLine("1.Address");
                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Enter the new First Name");
                            contact.Value.FirstName = Console.ReadLine();
                            break;
                        case 2:
                            Console.WriteLine("Enter the Last Name");
                            contact.Value.LastName = Console.ReadLine();
                            break;
                        case 3:
                            Console.WriteLine("Enter the Email");
                            contact.Value.Email = Console.ReadLine();
                            break;
                        case 4:
                            Console.WriteLine("Enter the City");
                            contact.Value.City = Console.ReadLine();
                            break;
                        case 5:
                            Console.WriteLine("Enter the phone Number");
                            contact.Value.PhoneNumber = Console.ReadLine();
                            break;
                        case 6:
                            Console.WriteLine("Enter the Address");
                            contact.Value.Address = Console.ReadLine();
                            break;
                        case 7:
                            Console.WriteLine("Enter the State ");
                            contact.Value.State = Console.ReadLine();
                            break;
                        case 8:
                            Console.WriteLine("Enter the Zip");
                            contact.Value.Zip = Convert.ToInt64(Console.ReadLine());
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Contact not found");
                }

            }
        }
        public void DeleteContact()
        {
            Console.WriteLine("Enter the First Name");
            string name = Console.ReadLine();
            //CreateContact deleteContact = new CreateContact();
            foreach (var contact in addressBookDictionry)
            {
                if (addressBookDictionry.ContainsKey(name))
                {

                    addressBookDictionry.Remove(name);
                    Console.WriteLine("Contact hsa been Delete");
                    break;
                }   //deleteContact = contact;
                else
                {
                    Console.WriteLine("Enter Vaild Name");
                }
            }
        }
        public void SearchCity()
        {
            Console.Write("Enter the City Name: ");
            string CityName = Console.ReadLine();
            Console.WriteLine("All the Contact of: " + CityName);
            foreach (var contact in contactList.FindAll(x => x.City == CityName))
            {
                Console.WriteLine("Name: " + contact.FirstName + " " + contact.LastName);
            }
        }
        public void ViewCity()
        {
            Console.Write("Enter the City Name: ");
            string CityName = Console.ReadLine();
            Console.WriteLine("All the Contact Details of: " + CityName);

            //List<CreateContact> contactsCity = contactList.FindAll(x => x.City == CityName);
            //addressBookCity.Add(CityName, contactsCity);
            foreach (var contact in addressBookCity[CityName])
            {
                Console.WriteLine("First Name :" + contact.FirstName);
                Console.WriteLine("Last Name :" + contact.LastName);
                Console.WriteLine("Email:" + contact.Email);
                Console.WriteLine("City:" + contact.City);
                Console.WriteLine("Address :" + contact.Address);
                Console.WriteLine("State :" + contact.State);
                Console.WriteLine("Zip :" + contact.Zip);
                Console.WriteLine("Phone Number :" + contact.PhoneNumber);
            }
        }
        public void CountCity()
        {
            Dictionary<string, int> cityCount = new Dictionary<string, int>();

            foreach (var contact in contactList)
            {
                if (!cityCount.ContainsKey(contact.City))
                {
                    cityCount.Add(contact.City, 1);
                }
                else
                {
                    cityCount[contact.City]++;
                }
            }

            Console.WriteLine("City-wise count of contacts:");
            foreach (var city in cityCount)
            {
                Console.WriteLine(city.Key + ": " + city.Value);
            }
        }
        public void SortByFirstName()
        {
            contactList.Sort((contact1, contact2) => contact1.FirstName.CompareTo(contact2.FirstName));

            Console.WriteLine("Contacts sorted by first name:");
            foreach (var contact in contactList)
            {
                Console.WriteLine(contact.FirstName + " " + contact.LastName);
            }
        }
        public void SortByCityAndStateAndZip()
        {
            var sortedList = contactList.OrderBy(x => x.City).ThenBy(x => x.State).ThenBy(x => x.Zip);
            Console.WriteLine("Contacts sorted by City and State:");
            foreach (var contact in sortedList)
            {
                Console.WriteLine($"Name: {contact.FirstName} {contact.LastName}, City: {contact.City}, State: {contact.State}, Zip: {contact.Zip}");
            }
        }
        public void FileRander()
        {
            string AddressContact = "D:\\RFP-demo\\AddressBooks\\AddressBooksProblem\\AddressBooks\\AddressBooks\\AddressBookContact\\AddressContact.txt";
            using (StreamReader streamReader = File.OpenText(AddressContact))
            {
                string print = "";
                while ((print = streamReader.ReadLine()) != null)
                {
                    Console.WriteLine(print);
                }
            }
        }
        public void FileWrite()
        {
            string AddressContact = "D:\\RFP-demo\\AddressBooks\\AddressBooksProblem\\AddressBooks\\AddressBooks\\AddressBookContact\\AddressContact.txt";
            using (StreamWriter streamWriter = File.AppendText(AddressContact))
            {
                foreach(var contact in addressBookDictionry)
                {
                    streamWriter.WriteLine("Frist Name:" + contact.Value.FirstName);
                    streamWriter.WriteLine("Last Name:" + contact.Value.LastName);
                    streamWriter.WriteLine("E-Mail:" + contact.Value.Email);
                    streamWriter.WriteLine("Phone Number:" + contact.Value.PhoneNumber);
                    streamWriter.WriteLine("Address:" + contact.Value.Address);
                    streamWriter.WriteLine("City:" + contact.Value.City);
                    streamWriter.WriteLine("State:" + contact.Value.State);
                    streamWriter.WriteLine("Zip:" + contact.Value.Zip);
                }
                streamWriter.Close();
                Console.WriteLine(File.ReadAllText(AddressContact));
            }
        }
    }
}
