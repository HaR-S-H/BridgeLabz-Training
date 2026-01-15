using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookUtility : IAddressBook
    {
        public string Name { get; private set; }
        private List<Person> persons = new List<Person>();

        public AddressBookUtility(string name)
        {
            Name = name;
        }

        // UC2, UC6, UC7
        public void AddPerson(Person person)
        {
            if (persons.Any(p => p.Equals(person)))
            {
                Console.WriteLine("Duplicate entry not allowed.");
                return;
            }

            persons.Add(person);
            Console.WriteLine("Person added successfully.");
        }

        // UC3
        public void EditPerson(string firstName, string lastName)
        {
            var person = persons.FirstOrDefault(p =>
                p.firstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                p.lastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));

            if (person == null)
            {
                Console.WriteLine("Person not found.");
                return;
            }

            Console.Write("New Address: ");
            string address = Console.ReadLine();
            Console.Write("New City: ");
            string city = Console.ReadLine();
            Console.Write("New State: ");
            string state = Console.ReadLine();
            Console.Write("New Zip: ");
            string zip = Console.ReadLine();
            Console.Write("New Phone: ");
            string phone = Console.ReadLine();
            Console.Write("New Email: ");
            string email = Console.ReadLine();

            person.Update(address, city, state, zip, phone, email);
            Console.WriteLine("Person updated.");
        }

        // UC4
        public void DeletePerson(string firstName, string lastName)
        {
            var person = persons.FirstOrDefault(p =>
                p.firstName.Equals(firstName, StringComparison.OrdinalIgnoreCase) &&
                p.lastName.Equals(lastName, StringComparison.OrdinalIgnoreCase));

            if (person == null)
            {
                Console.WriteLine("Person not found.");
                return;
            }

            persons.Remove(person);
            Console.WriteLine("Person deleted.");
        }

        // UC5
        public void DisplayAll()
        {
            if (!persons.Any())
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            foreach (var person in persons)
                Console.WriteLine(person);
        }

        // UC11
        public void SortByName()
        {
            persons = persons
                .OrderBy(p => p.firstName)
                .ThenBy(p => p.lastName)
                .ToList();

            Console.WriteLine("Sorted by name.");
        }

        // UC8, UC9, UC10
        public List<Person> GetAllPersons()
        {
            return persons;
        }
    }
}
