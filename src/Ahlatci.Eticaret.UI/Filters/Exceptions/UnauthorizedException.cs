﻿namespace Ahlatci.Eticaret.UI.Filters.Exceptions
{
    public class UnauthorizedException : Exception
    {
        public UnauthorizedException(string message) : base(message)
        {

        }

        public UnauthorizedException() : base("Bu alana erişim yetkiniz bulunmamaktadır.")
        {

        }
    }
}
