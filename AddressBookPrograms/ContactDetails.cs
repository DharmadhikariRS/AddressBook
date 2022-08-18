using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookPrograms
{
    internal class ContactDetails
    {
        string FirstName, LastName, Address, city, state;
        int zip, phoneNumber;

        public void Contacts(string FirstName, string LastName, string Address, string city, string state, int zip, int phoneNumber)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            Console.WriteLine("Your Contact Details are= ");
            Console.WriteLine("Name: " + FirstName + " " + LastName);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("city: " + city);
            Console.WriteLine("state: " + state);
            Console.WriteLine("zip: " + zip);
            Console.WriteLine("phoneNumber: " + phoneNumber);
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
