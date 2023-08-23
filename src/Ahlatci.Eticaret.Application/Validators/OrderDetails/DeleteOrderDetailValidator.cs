using Ahlatci.Eticaret.Application.Models.RequestModels.OrderDetails;
using FluentValidation;

namespace Ahlatci.Eticaret.Application.Validators.OrderDetails
{
    public class DeleteOrderDetailValidator : AbstractValidator<DeleteOrderDetailVM>
    {
        public DeleteOrderDetailValidator()
        {
            RuleFor(x => x.OrderDetailId)
                .NotEmpty().WithMessage("Sipariş detay numarası boş olamaz.")
                .GreaterThan(0).WithMessage("Sipariş detay numarası sıfırdan büyük olmalıdır.");
        }
    }
}
