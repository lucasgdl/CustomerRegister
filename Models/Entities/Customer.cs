using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoTeste.Util;

namespace Models.Entities
{
    public class Customer : Entity
    {
        public Customer(PersonName name, string email, Phone phone, Address address)
        {
            Name = name;
            Email = email;
            Phone = phone;
            Address = address;
        }

        public PersonName Name { get; set; }
        public String Email { get; set; }
        public Phone Phone { get; set; }
        public Address Address { get; set; }
    }
}
