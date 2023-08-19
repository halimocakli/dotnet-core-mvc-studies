using FluentValidation;

namespace Fluent_Validation.Models.FluentValidators
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(x => x.Title).NotNull().WithMessage("Zorunlu Alan!");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Zorunlu Alan!");
            RuleFor(x => x.Title).MaximumLength(16).WithMessage("Maksimum 16 Karakter Girebilirsiniz.");

            When(x => x.Title == "Deneme", () =>
            {
                RuleFor(x => x.PageCount).Must(y => y == 50).WithMessage("Kitap başlığı Deneme ise sayfa sayısı 50 olmalı.");
            });

            // RuleFor(x => x.PageCount).Must(y => int.TryParse(y, out int value)).WithMessage("Lütfen sayda sayısını nümerik bir değer ile ifade edin.");
        }
    }
}
