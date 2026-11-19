using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventOrganizerV2
{
    internal class Address
    {
        private string city;
        private Country country;
        private string street;
        private string zipCode;

        //Constructor

        public Address(string street, string zipCode, string city, Country country)
        {
            this.street = street;
            this.zipCode = zipCode;
            this.city = city;
            this.country = country;
        }

        //Properties
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public Country Country
        {
            get { return country; }
            set { country = value; }
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        public string ZipCode
        {
            get { return zipCode; }
            set { zipCode = value; }
        }

   
        //Methods
        public string GetAddressLabel()
        {
            return $"{street}, {zipCode} {city}, {country}";
        }

        public override string ToString()
        {
            return GetAddressLabel();
        }

        //ensures that the City is given
        public bool Validate()
        {
            return !string.IsNullOrEmpty(city);
        }
    }
}
