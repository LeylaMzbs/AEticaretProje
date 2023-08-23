using Ahlatci.Eticaret.Application.Models.RequestModels.Orders;
using FluentValidation;

namespace Ahlatci.Eticaret.Application.Validators.Orders
{
    public class DeleteOrderValidator : AbstractValidator<DeleteOrderVM>
    {
        public DeleteOrderValidator()
        {
            RuleFor(x => x.OrderId)
                .NotEmpty().WithMessage("Sipariş numarası boş olamaz.")
                .GreaterThan(0).WithMessage("Sipariş numarası sıfırdan büyük bir sayı olmalıdır.");
        }
    }
}
