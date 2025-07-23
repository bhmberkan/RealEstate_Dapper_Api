using RealEstate_Dapper_Api.Dtos.WriteUsInformationDtos;

namespace RealEstate_Dapper_Api.Repositories.WriteUsInformationRepository
{
    public interface IWriteUsInformationRepository
    {
        Task<List<ResultWriteUsInformationDto>> GetAllWriteUsInformationAsync();
        void CreateWriteUsInformation(CreateWriteUsInformationDto createWriteUsInformationDto);
        void UpdateWriteUsInformation(UpdateWriteUsInformationDto updateWriteUsInformationDto);

        void DeleteWriteUsInformation(int id);

        Task<GetByIdWriteUsInformationDto> GetWriteUsInformation(int id);
    }
}
