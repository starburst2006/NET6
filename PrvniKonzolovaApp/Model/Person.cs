using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvniKonzolovaApp.Model
{
    internal class Person
    {
        public Person(string firstname, string lastname)
        {
            FirstName = firstname;
            LastName = lastname;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirdth { get; set; }
        public Address Address { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
