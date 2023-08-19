using Ahlatci.Eticaret.Application.Models.RequestModels.Accounts;
using FluentValidation;

namespace Ahlatci.Eticaret.Application.Validators.Accounts
{
    public class LoginValidator : AbstractValidator<LoginVM>
    {
        //Fluent Validation: Her Modelimiz için bir validasyon yapmamızı sağlar.
        //Model doğrulama işlemi için kullanılır.
        //Kullanıcıların girmiş olduğu verilerin veritabanına kaydedilmeden önce istenen
        //şartları sağlayıp sağlamadığını kontrol eder.
        public LoginValidator()
        {
            RuleFor(x => x.Username)
                .NotEmpty().WithMessage("Kullanıcı adı boş olamaz.")
                .MaximumLength(10).WithMessage("Kullanıcı adı en fazla 10 karakter olabilir.");

            RuleFor(x => x.Password)
                .NotEmpty().WithMessage("Parola boş olamaz.")
                .MaximumLength(10).WithMessage("Parola en fazla 10 karakter olabilir.");
        }
    }
}

