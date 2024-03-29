﻿using Ahlatci.Eticaret.Domain.Entities;

namespace Ahlatci.Eticaret.Domain.Services.Abstraction
{
    public interface ILoggedUserService
    {
        int? UserId { get; }
        Roles? Role { get; }
        string Username { get; }
        string Email { get; }
    }
}
