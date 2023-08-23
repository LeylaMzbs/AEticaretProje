namespace Ahlatci.Eticaret.UI.Filters.Exceptions
{
    public class UnauthenticatedException : Exception
    {
        public UnauthenticatedException(string message) : base(message)
        {

        }

        public UnauthenticatedException() : base("Devam etmek için sisteme giriş yapmalısınız.")
        {

        }
    }
}
