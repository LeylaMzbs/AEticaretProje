using Ahlatci.Eticaret.Domain.Entities.Common;

namespace Ahlatci.Eticaret.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public string Name { get; set; }

        //Navigation Property
        public ICollection<Product> Products { get; set; }

    }
}
