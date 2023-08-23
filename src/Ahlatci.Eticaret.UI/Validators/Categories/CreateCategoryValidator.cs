using Ahlatci.Eticaret.UI.Models.RequestModels;
using FluentValidation;

namespace Ahlatci.Eticaret.UI.Validators.Categories
{
    //Fluent Validation: Her Modelimiz için bir validasyon yapmamızı sağlar.
    //Model doğrulama işlemi için kullanılır.
    public class CreateCategoryValidator : AbstractValidator<CreateCategoryVM>
    {
        public CreateCategoryValidator()
        {
            //Kural.
            RuleFor(x => x.CategoryName)
                .NotEmpty() //Boş değil.boşluk,null,0 olamaz.
                .WithMessage("Kategori adı boş olamaz.")
                .MaximumLength(100)
                .WithMessage("Kategori adı 100 karakterden fazla olamaz.");
        }
    }
}
