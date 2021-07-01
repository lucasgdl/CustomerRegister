using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserForm.ValueObjects
{
    public class PersonName
    {
        public String FirstName { get; private set; }
        public String MiddleName { get; private set; }
        public String LastName { get; private set; }

        public String FullName => $"{FirstName} {MiddleName} {LastName}";
    }
}
