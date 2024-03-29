﻿using Ahlatci.Eticaret.Domain.Entities.Common;

namespace Ahlatci.Eticaret.Domain.Entities
{
    public class Account : BaseEntity
    {
        public int CustomerId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string LastUserIp { get; set; }
        public Roles Role { get; set; }

        //Navigation Property
        public Customer Customer { get; set; }
    }

    public enum Roles
    {
        User = 1,
        Admin = 2
    }

}

