using System;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from the console phonebook app");
            Console.WriteLine("Select Operation");
            Console.WriteLine("1 Add Contact");
            Console.WriteLine("2 Display contact by number");
            Console.WriteLine("3 View all contacts");
            Console.WriteLine("4 Sarch for contacts for a given name");
            Console.WriteLine("Press 'x' to exit");

            var userInput = Console.ReadLine();

            var phoneBook = new PhoneBook();

            while (true)
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Contact Name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Contact Number:");
                        var number = Console.ReadLine();
                        var newContact = new Contact(name, number);
                        phoneBook.AddContact(newContact);
                        break;
                    case "2":
                        Console.WriteLine("Contact Number:");
                        var searchNumber = Console.ReadLine();
                        phoneBook.DisplayContact(searchNumber);
                        break;
                    case "3":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "4":
                        Console.WriteLine("Name Search Phrase");
                        var searchPhrase = Console.ReadLine();
                        phoneBook.DisplayMatchingContacts(searchPhrase);
                        break;
                    case "x":
                        return;
                    default:
                        Console.WriteLine("Select Valid Operation");
                        break;
                }

                Console.WriteLine("Select Operation:");
                userInput = Console.ReadLine();
            }
        }
    }
}
