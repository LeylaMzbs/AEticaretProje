using Ahlatci.Eticaret.UI.Models.Dtos;
using Ahlatci.Eticaret.UI.Models.RequestModels;
using AutoMapper;

namespace Ahlatci.Eticaret.UI.ModelMappings
{
    public class DtoToVm : Profile
    {
        public DtoToVm()
        {
            CreateMap<CategoryDto, UpdateCategoryVM>()
                .ForMember(x => x.CategoryName, y => y.MapFrom(e => e.Name));
        }
    }
}
