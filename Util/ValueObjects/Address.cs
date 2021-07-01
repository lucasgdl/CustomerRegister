using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.ValueObjects
{
    public class Address
    {
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
