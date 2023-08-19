using Ahlatci.Eticaret.Application.Models.RequestModels.Accounts;
using Ahlatci.Eticaret.Application.Models.RequestModels.Categories;
using Ahlatci.Eticaret.Application.Models.RequestModels.Cities;
using Ahlatci.Eticaret.Application.Models.RequestModels.ProductImages;
using Ahlatci.Eticaret.Application.Models.RequestModels.Products;
using Ahlatci.Eticaret.Domain.Entities;
using AutoMapper;

namespace Ahlatci.Eticaret.Application.Automappings
{
    public class ViewModelToDomain : Profile
    {     //Automapper kütüphanesi ile gelen sınıftan türetildi.
        public ViewModelToDomain() //Kurucu Metod içerisinde işlemler yapıldı.
        {   
            //Kaynak ve hedef arasında property isimleri veya türleri eşleşmezse manuel olaral tanımlama yapmak gerekiyor.
            CreateMap<CreateCategoryVM, Category>()
                .ForMember(x => x.Name, y => y.MapFrom(e => e.CategoryName));
                //Hedef obje                   //Kaynak obje
            CreateMap<UpdateCategoryVM, Category>()
                .ForMember(x => x.Name, y => y.MapFrom(e => e.CategoryName));

            //Kullanıcı oluşturma isteği
            CreateMap<RegisterVM, Customer>();
            CreateMap<RegisterVM, Account>()
                .ForMember(x => x.Role, y => y.MapFrom(e => Roles.User));

            CreateMap<UpdateUserVM, Customer>();

            //City
            CreateMap<CreateCityVM, City>()
                .ForMember(x => x.Name, y => y.MapFrom(e => e.Name.ToUpper()));
            CreateMap<UpdateCityVM, City>()
                .ForMember(x => x.Name, y => y.MapFrom(e => e.Name.ToUpper()));

            //Product
            CreateMap<CreateProductVM, Product>()
                .ForMember(x => x.Name, y => y.MapFrom(e => e.Name.Trim()));
            CreateMap<UpdateProductVM, Product>()
                .ForMember(x => x.Name, y => y.MapFrom(e => e.Name.Trim()));

            //ProductImage
            CreateMap<CreateProductImageVM, ProductImage>();
        }
    }
}
