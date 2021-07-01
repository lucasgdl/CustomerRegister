using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserForm.ValueObjects;

namespace UserForm.Entities
{
    public class Customer : Entity
    {
        public Customer(PersonName name, Address address, Phone phone, string email)
        {
            Name = name;
            Address = address;
            Phone = phone;
            Email = email;
        }

        public PersonName Name { get; set; }
        public Address Address { get; set; }
        public Phone Phone{ get; set; }
        public String Email{ get; set; }
    }
}
