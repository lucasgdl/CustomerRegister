using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.ValueObjects
{
    public class Zipcode
    {
        public Zipcode(string value)
        {
            Value = value;
        }

        public String Value { get; private set; }

        public String Masked => Convert.ToUInt64(Value).ToString(@"00000\-000");

        public String Unmasked => Value.Replace("-", string.Empty);
    }
}
