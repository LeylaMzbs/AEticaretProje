using Ahlatci.Eticaret.Application.Models.RequestModels.ProductImages;
using FluentValidation;

namespace Ahlatci.Eticaret.Application.Validators.ProductImages
{
    public class DeleteProductImageValidator : AbstractValidator<DeleteProductImageVM>
    {
        public DeleteProductImageValidator()
        {
            RuleFor(x => x.Id)
                .NotNull().WithMessage("Silinecek ürün resmine ait kimlik bilgisi boş bırakılamaz.")
                .GreaterThan(0).WithMessage("Silinecek ürün resmi kimlik bilgisi sıfırdan büyük olmalıdır.");
        }
    }
}

