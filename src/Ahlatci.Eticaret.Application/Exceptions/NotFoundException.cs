namespace Ahlatci.Eticaret.Application.Exceptions
{
    public class NotFoundException : Exception
    {
        //Exception'ların Exception türüne uygun bir exception tipiyle ifade edilmesi.
        public NotFoundException(string message) : base(message)
        {

        }

        public NotFoundException() : base()
        {

        }
    }
}

