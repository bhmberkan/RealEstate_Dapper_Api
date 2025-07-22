using RealEstate_Dapper_Api.Dtos.AboutUsDtos;

namespace RealEstate_Dapper_Api.Repositories.AboutUsRepository
{
    public interface IAboutUsRepository
    {
        Task<List<ResultAboutUsDto>> GetAllAboutUsAsync();
        void CreateAboutUs(CreateAboutUsDto createAboutUsDto);
        void UpdateAboutUs(UpdateAboutUsDto updateAboutUsDto);

        void DeleteAboutUs(int id);

        Task<GetByIdAboutUsDto> GetAboutUs(int id);
    }
}
