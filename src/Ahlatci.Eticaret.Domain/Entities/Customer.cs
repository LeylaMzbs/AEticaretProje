using Ahlatci.Eticaret.Domain.Entities.Common;

namespace Ahlatci.Eticaret.Domain.Entities
{
    public class Customer : AuditableEntity
    {
        public int CityId { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Birtdate { get; set; }
        public Gender Gender { get; set; }

        //Navigation Property
        public Account Account { get; set; }
        public City City { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }

    public enum Gender
    {
        Male = 1,
        Female = 2
    }
}