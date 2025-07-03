using RealEstate_Dapper_Api.Dtos.ServiceDtos;

namespace RealEstate_Dapper_Api.Repositories.ServiceRepository
{
    public interface IServiceRepository
    {
        Task<List<ResultServiceDto>> GetAllServiceAsync();
        void CreateService(CreateServiceDto createServiceDto);
        void UpdateService(UpdateServiceDto updateServiceDto);

        void DeleteService(int id);

        Task<GetByIdServiceDto> GetService(int id);
    }
}
