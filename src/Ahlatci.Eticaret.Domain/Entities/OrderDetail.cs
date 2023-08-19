using Ahlatci.Eticaret.Domain.Entities.Common;

namespace Ahlatci.Eticaret.Domain.Entities
{
    public class OrderDetail : AuditableEntity
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        //Navigation Property
        public Order Order { get; set; }
        public Product Product { get; set; }
    }
}
