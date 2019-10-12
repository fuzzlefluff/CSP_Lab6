using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public Person()
        {
            Name = "0";
            Address = "0";
            Phone = "0";
            Email = "0";
        }
        public Person(string Name, string Address, string Phone, string Email)
        {
            this.Name = Name;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
        }
        public void Display()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Address);
            Console.WriteLine(Phone);
            Console.WriteLine(Email);
        }

    }
}
