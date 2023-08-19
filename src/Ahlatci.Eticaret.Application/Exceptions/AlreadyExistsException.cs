namespace Ahlatci.Eticaret.Application.Exceptions
{
    public class AlreadyExistsException : Exception
    {
        //Exception'ların Exception türüne uygun bir exception tipiyle ifade edilmesi.

        public AlreadyExistsException(string message) : base(message)
        {

        }

        public AlreadyExistsException() : base()
        {

        }
    }
}
