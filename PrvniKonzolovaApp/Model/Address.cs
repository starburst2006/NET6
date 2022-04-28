using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvniKonzolovaApp.Model
{
    public class Address
    {
        public Address(string street, string city, string postalCode, string country)
        {
            Street = street;
            City = city;
            PostalCode = postalCode;
            Country = country;
        }
        public Address()
        {

        }
        public int Id { get; set; }
        public string Street { get; set; } = "";
        public string City { get; set; } = "";
        public String PostalCode { get; set; } = "";
        public string Country { get; set; } = "Česká republika";

        public override string ToString()
        {
            return $"{Street}, {City} {PostalCode}, {Country}";
        }
    }
}
