using System;

namespace AddressBookADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook");
            AddressRepo repo = new AddressRepo();
            AddressModel person = new AddressModel();
            person.FirstName = "SRI";
            person.LastName = "RAM";
            person.Address = "#354 VIdyanagar";
            person.PhoneNumber = "6565652351";
            person.zip = 573201;
            person.City = "Hassan";
            person.State = "karnataka";
            person.Email = "Ram@gmail.com";
            person.AddressBookName = "book4";
            person.Type = "Family";

            repo.GetAllEmployee();
            Console.ReadKey();
        }
    }
}
