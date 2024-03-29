﻿using Ahlatci.Eticaret.Domain.Entities.Common;

namespace Ahlatci.Eticaret.Domain.Entities
{
    public class Order : AuditableEntity
    {
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public DateTime? OrderDate { get; set; }
        public OrderStatus Status { get; set; }

        //Navigation Property
        public Customer Customer { get; set; }
        public Address Address { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }


    public enum OrderStatus
    {
        OrderCreated = 1,
        PaymentComplated = 2,
        Pending = 3,
        OrderDelivering = 4,
        CargoDelivered = 5,
        Complated = 6
    }
}

