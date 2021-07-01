using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserForm.ValueObjects.Validations
{
    public class ZipcodeValidator : AbstractValidator<Zipcode>
    {
        public ZipcodeValidator()
        {
            RuleFor(x => x.Value)
                .NotNull()
                .NotEmpty();
        }
    }
}
