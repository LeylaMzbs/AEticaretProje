using Ahlatci.Eticaret.Application.Models.Dtos.OrderDetails;
using Ahlatci.Eticaret.Application.Models.Dtos.Orders;
using Ahlatci.Eticaret.Application.Models.RequestModels.OrderDetails;
using Ahlatci.Eticaret.Application.Models.RequestModels.Orders;
using Ahlatci.Eticaret.Application.Wrapper;

namespace Ahlatci.Eticaret.Application.Services.Abstraction
{
    public interface IOrderDetailService
    {
        #region Select
        Task<Result<List<OrderDto>>> GetOrdersByCustomer(GetOrdersByCustomerVM getOrdersByCustomerVM);

        #endregion

        #region Insert, Update, Delete
        Task<Result<int>> CreateOrder(CreateOrderVM createOrderVM);
        Task<Result<int>> UpdateOrder(UpdateOrderVM updateOrderVM);
        Task<Result<int>> DeleteOrder(DeleteOrderVM deleteOrderVM);
        #endregion
    }
}
