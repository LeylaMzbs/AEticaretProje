using Ahlatci.Eticaret.Application.Models.RequestModels.Categories;
using FluentValidation;

namespace Ahlatci.Eticaret.Application.Validators.Categories
{
    //Fluent Validation: Her Modelimiz için bir validasyon yapmamızı sağlar.
    //Model doğrulama işlemi için kullanılır.
    public class DeleteCategoryValidator : AbstractValidator<DeleteCategoryVM>
    {
        public DeleteCategoryValidator()
        {
            //Kural.
            RuleFor(x => x.Id) //Dışarıdan id alınıyor.
                .NotEmpty()    //Boş değil.boşluk,null,0 olamaz.
                .WithMessage("Kategori kimlik numarası boş bırakılamaz.")
                .GreaterThan(0)
                .WithMessage("Kategori kimlik bilgisi sıfırdan büyük olmalıdır.");
        }
    }
}

