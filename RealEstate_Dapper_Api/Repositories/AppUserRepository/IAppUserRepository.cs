using RealEstate_Dapper_Api.Dtos.AppUserDtos;

namespace RealEstate_Dapper_Api.Repositories.AppUserRepository
{
    public interface IAppUserRepository
    {
        Task<GetAppUserByProductIdDto> GetAppUserByProductId(int id);
        Task<GetAppUserByProductIdDto> GetAppUserByProductId2(int id);

        Task<List<ResultAppUserDto>> GetAllAppUserAsync();
        void CreateAppUser(CreateAppUserDto createAboutUsDto);
        void UpdateAppUser(UpdateAppUserDto updateAboutUsDto);

        void DeleteAppUser(int id);

        Task<GetByIdAppUserDto> GetAppUser(int id);
    }
}
