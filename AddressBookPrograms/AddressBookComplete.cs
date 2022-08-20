using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookPrograms
{
    internal class AddressBookComplete
    {
        string FirstName, LastName, Address, city, state, email;
        int zip; long phoneNumber;

        public AddressBookComplete(string FirstName, string LastName, string Address, string city, string state, int zip, long phoneNumber, string email)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }
        public void DisplayValues()
        {
            Console.WriteLine(" FirstName= " + FirstName + "\n LastName= " + LastName + " \n Address= " + Address + "\n city= " + city + "\n state= " + state + "\n zip= " + zip + "\n phoneNumber= " + phoneNumber + "\n email= " + email + "\n");
        }

        public void EditValues(int field)
        {
            if (field == 1)
            {
                Console.WriteLine("Enter corrected lastName");
                this.LastName = Console.ReadLine();
            }
            else
            if (field == 2)
            {
                Console.WriteLine("Enter corrected Address");
                this.Address = Console.ReadLine();

            }
            else
            if (field == 3)
            {
                Console.WriteLine("Enter corrected City");
                this.city = Console.ReadLine();

            }
            else
            if (field == 4)
            {
                Console.WriteLine("Enter corrected State");
                this.state = Console.ReadLine();

            }
            else
            if (field == 5)
            {
                Console.WriteLine("Enter corrected Zip");
                this.zip = int.Parse(Console.ReadLine());
            }
            else
            if (field == 6)
            {
                Console.WriteLine("Enter corrected PhoneNumber");
                this.phoneNumber = long.Parse(Console.ReadLine());
            }
            else
            {
                if (field == 7)
                {
                    Console.WriteLine("Enter corrected email");
                    this.email = Console.ReadLine();
                }
            }
        }
    }
}
