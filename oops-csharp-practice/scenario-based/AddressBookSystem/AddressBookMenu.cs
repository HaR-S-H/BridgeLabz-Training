using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookMenu
    {
        private List<AddressBookUtility> addressBooks = new List<AddressBookUtility>();

        public void Start()
        {
            Console.WriteLine("Welcome to Address Book Program");

            while (true)
            {
                Console.WriteLine("\n1. Create Address Book");
                Console.WriteLine("2. Add Contact");
                Console.WriteLine("3. Edit Contact");
                Console.WriteLine("4. Delete Contact");
                Console.WriteLine("5. Display All Contacts");
                Console.WriteLine("6. Sort Contacts by Name");
                Console.WriteLine("7. Search Person by City/State");
                Console.WriteLine("8. Count by City/State");
                Console.WriteLine("0. Exit");

                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        CreateAddressBook();
                        break;
                    case 2:
                        AddContact();
                        break;
                    case 3:
                        EditContact();
                        break;
                    case 4:
                        DeleteContact();
                        break;
                    case 5:
                        DisplayAll();
                        break;
                    case 6:
                        SortContacts();
                        break;
                    case 7:
                        SearchByCityOrState();
                        break;
                    case 8:
                        CountByCityOrState();
                        break;
                    case 0:
                        return;
                }
            }
        }

        private void CreateAddressBook()
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();

            if (addressBooks.Any(b => b.Name == name))
            {
                Console.WriteLine("Address Book already exists.");
                return;
            }

            addressBooks.Add(new AddressBookUtility(name));
            Console.WriteLine("Address Book created.");
        }

        private AddressBookUtility SelectBook()
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();

            var book = addressBooks.FirstOrDefault(b => b.Name == name);
            if (book == null)
            {
                Console.WriteLine("Address Book not found.");
                return null;
            }
            return book;
        }

        private void AddContact()
        {
            var book = SelectBook();
            if (book == null) return;

            var person = ConsoleUtility.GetPersonFromConsole();
            book.AddPerson(person);
        }

        private void EditContact()
        {
            var book = SelectBook();
            if (book == null) return;

            Console.Write("First Name: ");
            string first = Console.ReadLine();
            Console.Write("Last Name: ");
            string last = Console.ReadLine();

            book.EditPerson(first, last);
        }

        private void DeleteContact()
        {
            var book = SelectBook();
            if (book == null) return;

            Console.Write("First Name: ");
            string first = Console.ReadLine();
            Console.Write("Last Name: ");
            string last = Console.ReadLine();

            book.DeletePerson(first, last);
        }

        private void DisplayAll()
        {
            var book = SelectBook();
            if (book == null) return;

            book.DisplayAll();
        }

        private void SortContacts()
        {
            var book = SelectBook();
            if (book == null) return;

            book.SortByName();
        }

        private void SearchByCityOrState()
        {
            Console.Write("Enter City or State: ");
            string key = Console.ReadLine();

            var results = addressBooks
                .SelectMany(b => b.GetAllPersons())
                .Where(p => p.city == key || p.state == key);

            foreach (var p in results)
                Console.WriteLine(p);
        }

        private void CountByCityOrState()
        {
            Console.Write("Enter City or State: ");
            string key = Console.ReadLine();

            int count = addressBooks
                .SelectMany(b => b.GetAllPersons())
                .Count(p => p.city == key || p.state == key);

            Console.WriteLine("Total Contacts: " + count);
        }
    }
}
