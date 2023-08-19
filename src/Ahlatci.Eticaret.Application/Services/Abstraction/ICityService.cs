using Ahlatci.Eticaret.Application.Models.Dtos.Cities;
using Ahlatci.Eticaret.Application.Models.RequestModels.Cities;
using Ahlatci.Eticaret.Application.Wrapper;

namespace Ahlatci.Eticaret.Application.Services.Abstraction
{
    public interface ICityService
    {
        Task<Result<List<CityDto>>> GetAllCities();
        Task<Result<CityDto>> GetCityById(int id);

        Task<Result<int>> CreateCity(CreateCityVM createCityVM);
        Task<Result<bool>> UpdateCity(UpdateCityVM updateCityVM);
        Task<Result<bool>> DeleteCity(int id);
    }
}
