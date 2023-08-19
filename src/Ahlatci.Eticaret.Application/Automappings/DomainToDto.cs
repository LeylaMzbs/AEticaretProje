using Ahlatci.Eticaret.Application.Models.Dtos;
using Ahlatci.Eticaret.Application.Models.Dtos.Accounts;
using Ahlatci.Eticaret.Application.Models.Dtos.Categories;
using Ahlatci.Eticaret.Application.Models.Dtos.Cities;
using Ahlatci.Eticaret.Application.Models.Dtos.Customers;
using Ahlatci.Eticaret.Application.Models.Dtos.ProductImages;
using Ahlatci.Eticaret.Application.Models.Dtos.Products;
using Ahlatci.Eticaret.Domain.Entities;
using AutoMapper;

namespace Ahlatci.Eticaret.Application.Automappings
{
    public class DomainToDto : Profile
    {   //Automapper kütüphanesi ile gelen sınıftan türetildi.
        public DomainToDto() //Kurucu Metod içerisinde işlemler yapıldı.
        {   //Kaynak Domain objeleri Dto objesine çevrildi(Map'lendi).
            CreateMap<Category, CategoryDto>();

            CreateMap<Customer, CustomerDto>();

            CreateMap<Account, AccountDto>();

            CreateMap<City, CityDto>();

            CreateMap<Product, ProductDto>();

            CreateMap<Product, ProductWithCategoryDto>();

            CreateMap<ProductImage, ProductImageDto>();

            CreateMap<ProductImage, ProductImageWithProductDto>();
        }
    }
}
