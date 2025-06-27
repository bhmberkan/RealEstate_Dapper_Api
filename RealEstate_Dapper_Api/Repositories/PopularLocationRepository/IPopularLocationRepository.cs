using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;

namespace RealEstate_Dapper_Api.Repositories.PopularLocationRepository
{
    public interface IPopularLocationRepository
    {
        Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync();
        void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto);
        void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto);

        void DeletePopularLocation(int id);

        Task<GetByIdPopularLocationDto> GetPopularLocation(int id);
    }
}
