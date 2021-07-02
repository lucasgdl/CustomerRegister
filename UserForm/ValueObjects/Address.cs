using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserForm.Entities;

namespace UserForm.ValueObjects
{
    public class Address : Entity
    {
        public Address() { }
        public Address(Zipcode zipCode, string street, string number, string complement, string neighborhood, string city, string state)
        {
            ZipCode = zipCode;
            Street = street;
            Number = number;
            Complement = complement;
            Neighborhood = neighborhood;
            City = city;
            State = state;
        }

        /// <summary>
        /// 
        /// </summary>
        /// Para injetar os valores corretamente usar a máscade de exemplo
        /// "{Street},{Number},{Neighborhood},{City},{State},{ZipCode.Unmasked},{Complement}"
        /// </param>
        public Address(string address)
        {
            var data = address.Split(",");
            Street = data[0];
            Number = data[1];
            Neighborhood = data[3];
            City = data[4];
            State = data[6];
            ZipCode = new Zipcode(data[7]);
            Complement = data[8];
        }

        public Zipcode ZipCode { get; private set; }
        public String Street { get; private set; }
        public String Number { get; private set; }
        public String Complement { get; private set; }
        public String Neighborhood { get; private set; }
        public String City { get; private set; }
        public String State { get; private set; }


        public String GoogleMapsMask => $"{Street}, {Number} - {Neighborhood}, {City} - {State}, {ZipCode.Masked}";
        public String FullAddress => $"{Street},{Number},{Neighborhood},{City},{State},{ZipCode.Unmasked},{Complement}";

    }
}
