using Ahlatci.Eticaret.Domain.Entities;

namespace Ahlatci.Eticaret.Application.Models.Dtos.Accounts
{
    public class TokenDto
    {
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
        public Roles Role { get; internal set; }
    }
}

