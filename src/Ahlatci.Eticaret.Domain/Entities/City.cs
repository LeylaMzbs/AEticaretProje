using Ahlatci.Eticaret.Domain.Entities.Common;

namespace Ahlatci.Eticaret.Domain.Entities
{
    public class City : BaseEntity
    {
        public string Name { get; set; }

        //Navigation Property
        public ICollection<Customer> Customers { get; set; }
        public ICollection<Address> Addresses { get; set; }
    }
}

