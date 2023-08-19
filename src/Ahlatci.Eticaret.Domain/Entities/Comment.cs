using Ahlatci.Eticaret.Domain.Entities.Common;

namespace Ahlatci.Eticaret.Domain.Entities
{
    public class Comment : AuditableEntity
    {
        public int ProductId { get; set; }
        public int CustomerId { get; set; }
        public string Detail { get; set; }
        public int LikeCount { get; set; }
        public int DislikeCount { get; set; }
        public bool? IsApproved { get; set; }

        //Navigation Property
        public Product Product { get; set; }
        public Customer Customer { get; set; }
    }
}
