using Ahlatci.Eticaret.Domain.Entities;
using Ahlatci.Eticaret.Domain.Services.Abstraction;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace Ahlatci.Eticaret.Domain.Services.Implementation
{
    public class LoggedUserService : ILoggedUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        public LoggedUserService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public int? UserId => GetClaim(ClaimTypes.PrimarySid) != null ? int.Parse(GetClaim(ClaimTypes.PrimarySid)) : null;

        public Roles? Role => GetClaim(ClaimTypes.Role) != null ? (Roles)Enum.Parse(typeof(Roles), GetClaim(ClaimTypes.Role)) : null;

        public string Username => GetClaim(ClaimTypes.Name) != null ? GetClaim(ClaimTypes.Name) : null;

        public string Email => GetClaim(ClaimTypes.Email) != null ? GetClaim(ClaimTypes.Email) : null;



        private string GetClaim(string claimType)
        {
            return _httpContextAccessor?.HttpContext?.User.Claims.FirstOrDefault(x => x.Type == claimType)?.Value;
        }
    }
}

