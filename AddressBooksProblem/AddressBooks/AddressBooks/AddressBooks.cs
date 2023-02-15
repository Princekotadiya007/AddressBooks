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

        public void CreateContact()
        {
            contact.FirstName = Console.ReadLine();
            contact.LastName = Console.ReadLine();
            contact.Email = Console.ReadLine();
            contact.City = Console.ReadLine();
            contact.PhoneNumber = Console.ReadLine();
            contact.Address = Console.ReadLine();
            contact.State = Console.ReadLine();
            contact.Zip = Convert.ToInt64(Console.ReadLine());   
        }
        public void Display()
        {
            Console.WriteLine("Contact Datails" + "\n"+"First Name"+contact.FirstName + "\nLastName"+contact.LastName+"\nEmail"+contact.Email+
                "\nCity"+contact.City+ "\nPhoneNumber"+contact.PhoneNumber+ "\nAdress"+contact.Address+ "\nState"+contact.State +"\nZip"+contact.Zip);
        }
    }
}
