using FluentValidation;

namespace Fluent_Validation.Models.FluentValidators
{
    public class BookTypeValidator : AbstractValidator<BookType>
    {
        public BookTypeValidator()
        {
            RuleFor(x => x.TypeName).NotNull().WithMessage("Zorunlu Alan!");
            RuleFor(x => x.TypeName).MaximumLength(16).WithMessage("Maksimum 16 Karakter Girebilirsiniz.");
            RuleFor(x => x.TypeName).NotEmpty().WithMessage("Zorunlu Alan!");
        }
    }
}
