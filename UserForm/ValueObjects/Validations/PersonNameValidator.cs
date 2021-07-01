using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserForm.ValueObjects.Validations
{
    public class PersonNameValidator : AbstractValidator<PersonName>
    {
        public PersonNameValidator()
        {
            RuleFor(x => x.FirstName)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.MiddleName)
                .NotNull()
                .NotEmpty();

            RuleFor(x => x.LastName)
                .NotNull()
                .NotEmpty();
        }
    }
}
