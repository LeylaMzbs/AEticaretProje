using Ahlatci.Eticaret.Application.Exceptions;
using Ahlatci.Eticaret.Application.Wrapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Serilog;

namespace Ahlatci.Eticaret.Api.Filters
{
    public class ExceptionHandlerFilter : IExceptionFilter
    {
        //AOP (Aspect Oriented Programming) birbirleri ile kesişen ilgilerin ayrılmasıdır.(Cross Cutting Concerns)
        //ActionFilter OnActionExecuted OnActionExecuting
        //Intercepter (Bölücü, Araya girici)
        //Tüm action metodlar çalışırken hata durumunda mutlaka buraya düşer.
        //Bu yazılan sınıfın her action için bir filt re olarak çalışması isteniyorsa
        //servis registirasyon aşamasında AddControllers kısmında (Program.cs) register edilmelidir.
        public void OnException(ExceptionContext context)
        {
            var result = new Result<dynamic>() { Success = false };

            if (context.Exception is NotFoundException notFoundException)
            {
                result.Errors = new List<string> { notFoundException.Message };
            }
            else if (context.Exception is AlreadyExistsException alreadyExistsException)
            {
                result.Errors = new List<string> { alreadyExistsException.Message };
            }
            else if (context.Exception is ValidateException validationException)
            {
                result.Errors.AddRange(validationException.ErrorMessages);
            }
            else
            {
                result.Errors = new List<string> { context.Exception.InnerException != null ? context.Exception.InnerException.Message : context.Exception.Message };
            }

            Log.Error(context.Exception, $"{context.HttpContext.Request.Path} adresi çağrılırken bir hata oluştu.");

            context.Result = new ObjectResult(result); //obje modelleme.
            context.HttpContext.Response.StatusCode = 400;

            context.ExceptionHandled = true; //Hata burada kesilir daha yukarıya taşınmaz.
        }
    }


    public class Test : IActionFilter
    {
        //Her action çalıştıktan sonra devreye girer.
        public void OnActionExecuted(ActionExecutedContext context)
        {
            throw new NotImplementedException();
        }

        //Bir action çalışırken devreye girer.
        public void OnActionExecuting(ActionExecutingContext context)
        {
            throw new NotImplementedException();
        }
    }

}


