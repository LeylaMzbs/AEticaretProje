﻿using Ahlatci.Eticaret.UI.Models.RequestModels.Cities;
using FluentValidation;

namespace Ahlatci.Eticaret.UI.Validators.Cities
{
    public class UpdateCityValidator : AbstractValidator<UpdateCityVM>
    {
        public UpdateCityValidator()
        {
            RuleFor(x => x.Id)
                .NotEmpty().WithMessage("Şehir kimlik numarası boş olamaz.")
                .GreaterThan(0).WithMessage("Şehir kimlik numarası sıfırdan büyük bir sayı olmalıdır.");

            RuleFor(x => x.Name)
                .NotNull().WithMessage("Şehir adı boş olamaz.")
                .MaximumLength(20).WithMessage("Şehir adı 20 karakterden büyük olamaz.");

        }
    }
}
