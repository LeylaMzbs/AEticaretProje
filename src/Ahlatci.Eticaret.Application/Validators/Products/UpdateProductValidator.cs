﻿using Ahlatci.Eticaret.Application.Models.RequestModels.Products;
using FluentValidation;

namespace Ahlatci.Eticaret.Application.Validators.Products
{
    public class UpdateProductValidator : AbstractValidator<UpdateProductVM>
    {
        public UpdateProductValidator()
        {
            RuleFor(x => x.Id)
                .NotNull().WithMessage("Ürün kimlik bilgisi boş olamaz.")
                .GreaterThan(0).WithMessage("Ürün kimlik bilgisi sıfırdan büyük bir sayı olmalıdır.");

            RuleFor(x => x.CategoryId)
                .NotNull().WithMessage("Ürüne ait kategori bilgisi boş olamaz.")
                .GreaterThan(0).WithMessage("Kategori bilgisi sıfırdan büyük bir sayı olmalıdır.");

            RuleFor(x => x.Name)
                .NotNull().WithMessage("Ürün adı boş olamaz.")
                .MaximumLength(255).WithMessage("Ürün adı en fazla 255 karakter olabilir.");

            RuleFor(x => x.Detail)
                .NotNull().WithMessage("Ürün detay bilgisi boş olamaz.");

            RuleFor(x => x.UnitInStock)
                .NotNull().WithMessage("Ürün stok adedi boş olamaz.");

            RuleFor(x => x.UnitPrice)
                .NotNull().WithMessage("Ürün fiyatı boş olamaz.");
        }
    }
}

