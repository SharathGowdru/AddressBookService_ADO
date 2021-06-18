using System;

namespace AddressBookADO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to AddressBook");
            AddressRepo repo = new AddressRepo();
            repo.GetSize();
            Console.ReadKey();
        }
    }
}
