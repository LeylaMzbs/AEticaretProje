﻿using Ahlatci.Eticaret.Application.Models.RequestModels.Orders;
using FluentValidation;

namespace Ahlatci.Eticaret.Application.Validators.Orders
{
    public class GetOrdersByCustomerValidator : AbstractValidator<GetOrdersByCustomerVM>
    {
        public GetOrdersByCustomerValidator()
        {
            RuleFor(x => x.CustomerId)
                .NotEmpty().WithMessage("Müşteri numarası boş olamaz.")
                .GreaterThan(0).WithMessage("Müşteri numarası sıfırdan büyük bir sayı olmalıdır.");
        }
    }
}
