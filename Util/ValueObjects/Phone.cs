using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util.ValueObjects
{
    public class Phone
    {
        public Phone(string value)
        {
            Value = value;
        }

        public String Value { get; private set; }

        public String Masked => Convert.ToUInt64(Value).ToString(@"(00)00000-0000");

        public String Unmasked => Value.Replace("-", string.Empty);
    }
}
