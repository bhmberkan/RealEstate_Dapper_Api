using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.EmployeeDtos;

namespace RealEstate_Dapper_Api.Repositories.EmployeeRepository
{
    public interface IEmployeeRepository
    {
        Task<List<ResultEmployeeDto>> GetAllEmployeeAsync();
        void CreateEmployee(CreateEmployeeDto createEmployeeDto);
        void UpdateEmployee(UpdateEmployeeDto updateEmployeeDto);

        void DeleteEmployee(int id);

        Task<GetByIdEmployeeDto> GetEmployee(int id);
    }
}
