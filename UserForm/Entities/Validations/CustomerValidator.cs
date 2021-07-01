using FluentValidation;

namespace UserForm.Entities.Validations
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.Email)
                .NotNull()
                .NotEmpty();
        }
    }
}
