namespace AddressBookPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book");

            //UC1

            //ContactDetails contact1 = new ContactDetails();
            //contact1.Contacts("Rushi", "Dharmadhikari", "Latur", "Latur", "Maharashtra", 413512, 2000000101);

            //ContactDetails contact2 = new ContactDetails();
            //contact2.Contacts("Rsd", "D", "Mumbai", "Bombay", "Maharashtra", 111111, 1000000021);

            //UC2
            //ContactDetailsUserInput contactDetailsUserInput = new ContactDetailsUserInput();
            //contactDetailsUserInput.ReaderContactDetails();
            //contactDetailsUserInput.DisplayContactDetails();

            //UC3

            //EditContactDetail editContactDetail = new EditContactDetail();

            //editContactDetail.Contacts("Rushi", "Dharmadhikari", "Latur", "Latur", "Maharashtra", 413512, 2000000101);
            //editContactDetail.DisplayContactDetails();
            //editContactDetail.edit();

            //UC4
            //DeleteContact deleteContact = new DeleteContact();
            //deleteContact.Contacts("Rushi", "Dharmadhikari", "Latur", "Latur", "Maharashtra", 413512, 2000000101);
            //deleteContact.DisplayContactDetails();
            //deleteContact.DeleteContacts();
            //Console.WriteLine("After delete details are");
            //deleteContact.DisplayContactDetails();

            // Complete address book

            Dictionary<string, AddressBookComplete> AddressDictionary = new Dictionary<string, AddressBookComplete>();
            bool a = true;
            int count = 0;
            while (a)
            {
                Console.WriteLine();
                Console.WriteLine("(Duplicate entry Condition using Lambda )To add details enter 1");

                Console.WriteLine("To Edit  details enter 2");

                Console.WriteLine("To Delete details enter 3");

                Console.WriteLine("To Display details enter 4");
                Console.WriteLine("To Exit  enter 5");
               

                int Case = int.Parse(Console.ReadLine());

                switch (Case)
                {
                    case 1:
                        string FirstName, LastName, Address, city, state, email;
                        int zip;
                        long phoneNumber;

                        Console.WriteLine("Enter FirstName");
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
                        phoneNumber = long.Parse(Console.ReadLine());
                        Console.WriteLine("Enter email");
                        email = Console.ReadLine();

                        AddressBookComplete addressBookComplete = new AddressBookComplete(FirstName, LastName, Address, city, state, zip, phoneNumber, email);
                        //  foreach (KeyValuePair<string, AddressBookComplete> Dict in AddressDictionary)
                        // {
                        // }
                        //Used Lambda Day23
                        if ( AddressDictionary.Any(x => (x.Key == FirstName)))
                            {
                            Console.WriteLine("XX Key Already exist XX ");
                             break;
                            }
                        else
                        {
                            AddressDictionary.Add(FirstName, addressBookComplete);
                            count++;
                        }
                      
                      
                        Console.WriteLine("+++++++++++Contact Added Successfully+++++++++++++");
                        break;
                    case 2:
                        Console.WriteLine("Enter Firstname to edit contact details");

                        string fname = (Console.ReadLine());
                        Console.WriteLine("Enter following numbers to edit peryicular field");
                        Console.WriteLine("1-LastName\n 2-Address \n 3-city\n 4-state \n 5-zip \n 6-phoneNum \n 7-email");
                        int field = int.Parse(Console.ReadLine());

                        foreach (var Dict in AddressDictionary)
                        {
                            if (Dict.Key == fname)
                            {
                                Console.WriteLine("Details for {0} is= " + fname);
                                Dict.Value.EditValues(field);
                            }
                        }
                        break;
                    case 3:

                        Console.WriteLine("Enter FirstNmae to Delete Contact");
                        string fname1 = (Console.ReadLine());

                        AddressDictionary.Remove(fname1);
                        Console.WriteLine("----------Contact Deleted Successfully----------------");
                        count--;
                        break;

                    case 4:
                        if (count > 0)
                        {
                            Console.WriteLine("If you want all contacs from AddressBook press 1 and for perticular key details press 2");
                            int YesNo = int.Parse(Console.ReadLine());

                            if (YesNo == 1)
                            {
                                Console.WriteLine("Contact Details are= ");

                                foreach (KeyValuePair<string, AddressBookComplete> Dict in AddressDictionary)
                                {
                                    Dict.Value.DisplayValues();

                                }
                            }
                            else
                            {
                                Console.WriteLine("Enter firstname to print details");
                                string key1 = Console.ReadLine();


                                foreach (KeyValuePair<string, AddressBookComplete> Dict in AddressDictionary)
                                {
                                    if (Dict.Key == key1)
                                    {
                                        Console.WriteLine("Details for {0} is= " + key1);
                                        Dict.Value.DisplayValues();
                                    }
                                }
                            }

                        }
                        else
                        {
                            Console.WriteLine("********No contact to display**********");
                        }
                        break;
                  
                    case 5:
                        a = false;
                        Console.WriteLine("......Exited........");
                        break;
                   
                    default:
                        Console.WriteLine("Enter correct Number");
                        break;

                }
            }

        }
    }
}