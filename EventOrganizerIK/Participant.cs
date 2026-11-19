using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizerV2
{
    internal class Participant
    {
        private Address address;
        private string firstName;
        private string lastName;

        //constructor
        public Participant(string firstName, string lastName, Address addressIn)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = addressIn;
        }

        //Properties
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public override string ToString()
        {
            return $"{lastName.ToUpper()}, {firstName} – {address}";
        }

    }
}
