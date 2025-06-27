using RealEstate_Dapper_Api.Dtos.BottomGridDtos;
using RealEstate_Dapper_Api.Dtos.CategoryDtos;

namespace RealEstate_Dapper_Api.Repositories.BottomGridRepository
{
    public interface IBottomGridRepository
    {
        Task<List<ResultBottomGridDto>> GetAllBottomGridAsync();
        void CreateBottomGrid(CreateBottomGridDto createBottomGridDto);
        void UpdateBottomGrid(UpdateBottomGridDto updateBottomGridDto);

        void DeleteBottomGrid(int id);

        Task<GetByIdBottomGridDto> GetBottomGrid(int id);
    }
}
