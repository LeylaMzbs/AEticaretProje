﻿using Ahlatci.Eticaret.Application.Models.Dtos.Categories;
using Ahlatci.Eticaret.Application.Models.Dtos.Products;

namespace Ahlatci.Eticaret.Application.Models.Dtos.OrderDetails
{
    public class OrderDetailDto
    {
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public CategoryDto Category { get; set; }
        public ProductDto Product { get; set; }
    }
}
