﻿namespace Ahlatci.Eticaret.UI.Models.RequestModels.OrderDetails
{
    public class CreateOrderDetailVM
    {
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? Quantity { get; set; }
    }
}
