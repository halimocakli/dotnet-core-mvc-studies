using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace Fluent_Validation.Models.FluentValidators
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.FirstName).NotNull().WithMessage("Zorunlu Alan!");
            RuleFor(x => x.LastName).NotNull().WithMessage("Zorunlu Alan!");

            RuleFor(x => x.FirstName).MaximumLength(16).WithMessage("Maksimum 16 Karakter Girebilirsiniz.");
            RuleFor(x => x.LastName).MaximumLength(16).WithMessage("Maksimum 16 Karakter Girebilirsiniz.");

            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Zorunlu Alan!");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Zorunlu Alan!");
        }
    }
}
