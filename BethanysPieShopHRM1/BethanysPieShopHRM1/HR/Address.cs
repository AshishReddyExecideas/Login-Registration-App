using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShopHRM1.HR
{
    internal class Address
    {
        private string street;
        private string houseNumber;
        private string zipcode;
        private string city;

        public Address(string street, string houseNumber, string zipcode, string city)
        {
            Street = street;
            HouseNumber = houseNumber;
            Zipcode = zipcode;
            City = city;
        }   

        public string Street 
        {
            get { return street; }
            set { street = value; }
        }

        public string HouseNumber
        { 
            get { return houseNumber; } 
            set { houseNumber = value; } 
        }

        public string Zipcode
        { 
            get { return zipcode; }
            set
            {
                zipcode = value;
            }
        }

        public string City
        { 
            get { return city; }
            set { city = value; }
        }
    }
}
