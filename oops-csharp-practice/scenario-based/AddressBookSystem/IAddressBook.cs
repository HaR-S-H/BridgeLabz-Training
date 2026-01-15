using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public interface IAddressBook
    {
        void AddPerson(Person person);
        void EditPerson(string firstName, string lastName);
        void DeletePerson(string firstName, string lastName);
        void DisplayAll();
        void SortByName();
    }
}
