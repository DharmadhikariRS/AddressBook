using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookPrograms
{
    internal class DeleteContact
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



        }
        public void DisplayContactDetails()
        {
            Console.WriteLine("Your Contact details are as below= ");
            Console.WriteLine("FirstName= " + FirstName);
            Console.WriteLine("LastName= " + LastName);
            Console.WriteLine("Address= " + Address);
            Console.WriteLine("city= " + city);
            Console.WriteLine("state= " + state);
            Console.WriteLine("zip= " + zip);
            Console.WriteLine("phoneNumber= " + phoneNumber);
        }

        public void DeleteContacts()
        {



            Console.WriteLine("If You want to delete details press 1");
            int Y = int.Parse(Console.ReadLine());
            if (Y == 1)
            {
                FirstName = null;
                LastName = null;
                Address = null;
                city = null;
                state = null;
                zip = 0;
                phoneNumber = 0;
            }
        }
    }
}
