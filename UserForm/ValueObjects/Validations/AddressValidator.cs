using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserForm.ValueObjects.Validations
{
    public class AddressValidator : AbstractValidator<Address>
    {
        public AddressValidator()
        {
            RuleFor(x => x.Street)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.Number)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.City)
                .NotEmpty()
                .NotNull();
            RuleFor(x => x.State)
                .NotEmpty()
                .NotNull();
        }
    }
}
