﻿namespace Ahlatci.Eticaret.Domain.Entities.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
