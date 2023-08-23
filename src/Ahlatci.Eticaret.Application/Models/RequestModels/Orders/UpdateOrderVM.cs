using Ahlatci.Eticaret.Domain.Entities;

namespace Ahlatci.Eticaret.Application.Models.RequestModels.Orders
{
    public class UpdateOrderVM
    {
        public int? OrderId { get; set; }
        public OrderStatus? StatusId { get; set; }
        public int AddressId { get; set; }
    }
}
