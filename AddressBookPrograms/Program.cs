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
            ContactDetailsUserInput contactDetailsUserInput = new ContactDetailsUserInput();
            contactDetailsUserInput.ReaderContactDetails();
            contactDetailsUserInput.DisplayContactDetails();
        }
    }
}