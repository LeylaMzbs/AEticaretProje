using FluentValidation.Results;


namespace Ahlatci.Eticaret.Application.Exceptions
{
    //Exception'ların Exception türüne uygun bir exception tipiyle ifade edilmesi.

    public class ValidateException : Exception
    {
        private System.ComponentModel.DataAnnotations.ValidationResult? validationResult;

        public List<string> ErrorMessages { get; set; }

        public ValidateException(ValidationResult result) : base()
        {
            ErrorMessages = result.Errors.Select(x => x.ErrorMessage).ToList();
        }

        public ValidateException(System.ComponentModel.DataAnnotations.ValidationResult? validationResult)
        {
            this.validationResult = validationResult;
        }
    }
}
