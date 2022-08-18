using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookPrograms
{
    internal class EditContactDetail
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
        public void edit()
        {
            Console.WriteLine();

            Console.WriteLine("enter respective number to edit required field");
            Console.WriteLine("Press 0 to update First Name");
            Console.WriteLine("Press 1 to update Last Name");
            Console.WriteLine("Press 2 to update Address");
            Console.WriteLine("Press 3 to update City");
            Console.WriteLine("Press 4 to update State");
            Console.WriteLine("Press 5 to update ZipCode");
            Console.WriteLine("Press 6 to update Phone Number");

            int ip = Convert.ToInt32(Console.ReadLine());
            switch (ip)
            {
                case 0:
                    Console.WriteLine("Enter first Name");
                    string FirstName = Console.ReadLine();
                    this.FirstName = FirstName;
                    break;
                case 1:
                    Console.WriteLine("Enter Last Name");
                    string LastName = Console.ReadLine();
                    this.LastName = LastName;
                    break;
                case 2:
                    Console.WriteLine("Enter Address");
                    string Address = Console.ReadLine();
                    this.Address = Address;
                    break;
                case 3:
                    Console.WriteLine("Enter City Name");
                    string city = Console.ReadLine();
                    this.city = city;
                    break;
                case 4:
                    Console.WriteLine("Enter State Name");
                    string state = Console.ReadLine();
                    this.state = state;
                    break;
                case 5:
                    Console.WriteLine("Enter ZIPCODE");
                    int zip = Convert.ToInt32(Console.ReadLine());
                    this.zip = zip;
                    break;
                case 6:
                    Console.WriteLine("Enter PhoneNumber");
                    int phoneNumber = Convert.ToInt32(Console.ReadLine());
                    this.phoneNumber = phoneNumber;
                    break;

            }
            Console.WriteLine("Contact updated Successfully");
            Console.WriteLine();
            DisplayContactDetails();
            Console.WriteLine();
        }
    }
}
