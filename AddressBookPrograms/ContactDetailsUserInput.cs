using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookPrograms
{
    internal class ContactDetailsUserInput
    {
        string FirstName, LastName, Address, city, state;
        int zip, phoneNumber;
        public void ReaderContactDetails()
        {
            Console.WriteLine("To create contact add the required details");

            Console.WriteLine("Enter Firstname");
            FirstName = Console.ReadLine();

            Console.WriteLine("Enter LastName");
            LastName = Console.ReadLine();

            Console.WriteLine("Enter Address");
            Address = Console.ReadLine();

            Console.WriteLine("Enter city");
            city = Console.ReadLine();

            Console.WriteLine("Enter state");
            state = Console.ReadLine();

            Console.WriteLine("Enter zip");
            zip = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter phoneNumber");
            phoneNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
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
    }
}
