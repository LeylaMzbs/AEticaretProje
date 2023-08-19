using Ahlatci.Eticaret.Domain.Entities;

namespace Ahlatci.Eticaret.Application.Models.Dtos.Customers
{
    public class CustomerDto
    {
        public int CityId { get; set; }
        public string IdentityNumber { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Birtdate { get; set; }
        public Gender Gender { get; set; }
    }
}
