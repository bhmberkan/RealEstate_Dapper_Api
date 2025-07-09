using RealEstate_Dapper_Api.Dtos.ToDoListDtos;

namespace RealEstate_Dapper_Api.Repositories.ToDoLitRepository
{
    public interface IToDoLitRepository
    {
        Task<List<ResultToDoListDto>> GetAllToDoListAsync();
        void CreateToDoList(CreateToDoListDto ToDoListDto);
        void UpdateToDoList(UpdateToDoListDto ToDoListDto);

        void DeleteToDoList(int id);

        Task<GetByIdToDoListDto> GetToDoList(int id);
    }
}
