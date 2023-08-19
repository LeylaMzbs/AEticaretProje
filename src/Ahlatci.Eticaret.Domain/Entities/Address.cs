using Ahlatci.Eticaret.Domain.Entities.Common;

namespace Ahlatci.Eticaret.Domain.Entities
{
    public class Address : BaseEntity
    {
        public int CityId { get; set; }
        public string Text { get; set; }

        //Navigation Property
        public City City { get; set; }
        public ICollection<Order> Orders { get; set; }
    }

}