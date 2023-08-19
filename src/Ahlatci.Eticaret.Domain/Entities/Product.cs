using Ahlatci.Eticaret.Domain.Entities.Common;

namespace Ahlatci.Eticaret.Domain.Entities
{
    public class Product : AuditableEntity
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Detail { get; set; }
        public int UnitInStock { get; set; }
        public decimal UnitPrice { get; set; }

        //Navigation Property
        public Category Category { get; set; }
        public ICollection<ProductImage> ProductImages { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
