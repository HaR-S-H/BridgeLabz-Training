using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Person
    {
        private string FirstName;
        private string LastName;
        private string Address;
        private string City;
        private string State;
        private string Zip;
        private string Phone;
        private string Email;

        public Person(string firstName, string lastName, string address,
                      string city, string state, string zip,
                      string phone, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.City = city;
            this.State = state;
            this.Zip = zip;
            this.Phone = phone;
            this.Email = email;
        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
        public string phone { get; set; }
        public string email { get; set; }

        // UC3 - Edit Contact

        public void Update(string address, string city, string state,
                           string zip, string phone, string email)
        {
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }

        // UC7 - Duplicate Check
        public override bool Equals(object obj)
        {
            if (obj is Person other)
                return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase)
                    && LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);

            return false;
        }

        // public override int GetHashCode()
        // {
        //     return (FirstName + LastName).ToLower().GetHashCode();
        // }

        // UC11 - Print Format
        public override string ToString()
        {
            return FirstName + " " + LastName + ", " + Address + ", " + City + ", " + State + ", " + Zip + ", " + Phone + ", " + Email;
        }
    }

}
