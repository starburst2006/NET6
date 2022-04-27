using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvniKonzolovaApp.Model
{
    internal class Address
    {
        public Address(string street, string city, int postalCode, string country)
        {
            Street = street;
            City = city;
            PostalCode = postalCode;
            Country = country;
        }
        public Address()
        {

        }

        public string Street { get; set; } = "";
        public string City { get; set; } = "";
        public int PostalCode { get; set; } = 00000;
        public string Country { get; set; } = "Česká republika";

        public override string ToString()
        {
            return $"{Street}, {City} {PostalCode}, {Country}";
        }
    }
}
