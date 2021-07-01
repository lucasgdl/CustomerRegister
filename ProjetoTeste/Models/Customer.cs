using System;
using Util.ValueObjects;

namespace ProjetoTeste.Models
{
    public class Customer : 
    {
        public Customer(PersonName name, Address address)
        {
            Name = name;
            Address = address;
        }

        public PersonName Name { get; set; }
        public String Email { get; set; }
        public Phone Phone { get; set; }
        public Address Address { get; set; }
    }
}
