using Ahlatci.Eticaret.Domain.Entities.Common;

namespace Ahlatci.Eticaret.Domain.Entities
{
    public class ProductImage : AuditableEntity
    {
        public int ProductId { get; set; }
        public string Path { get; set; }
        public int Order { get; set; }
        public bool? IsThumbnail { get; set; }

        //Navigation Property
        public Product Product { get; set; }
    }
}
