using Dapper;
using RealEstate_Dapper_Api.Dtos.WriteUsInformationDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.WriteUsInformationRepository
{
    public class WriteUsInformationRepository : IWriteUsInformationRepository
    {
        private readonly Context _context;

        public WriteUsInformationRepository(Context context)
        {
            _context = context;
        }

        public async void CreateWriteUsInformation(CreateWriteUsInformationDto createWriteUsInformationDto)
        {
            string query = "insert into WriteUsInformation (Address,Tel1,Tel2,Email,AddressUrl) values (@address,@tel1,@tel1,@email,@addressUrl)";
            var paramaters = new DynamicParameters();
            paramaters.Add("@Address", createWriteUsInformationDto.Address);
            paramaters.Add("@tel1", createWriteUsInformationDto.Tel1);
            paramaters.Add("@tel2", createWriteUsInformationDto.Tel2);
            paramaters.Add("@email", createWriteUsInformationDto.Email);
            paramaters.Add("@addressUrl", createWriteUsInformationDto.AddressUrl);


            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, paramaters);
            }
        }

        public async void DeleteWriteUsInformation(int id)
        {
            string query = "Delete From WriteUsInformation Where WriteUsInformationId=@writeUsInformationId";
            var parameters = new DynamicParameters();
            parameters.Add("@writeUsInformationId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultWriteUsInformationDto>> GetAllWriteUsInformationAsync()
        {
            string query = "Select * From WriteUsInformation";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultWriteUsInformationDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdWriteUsInformationDto> GetWriteUsInformation(int id)
        {
            string query = "Select * From WriteUsInformation Where WriteUsInformationId=@writeUsInformationId";
            var parameters = new DynamicParameters();
            parameters.Add("@writeUsInformationId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdWriteUsInformationDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateWriteUsInformation(UpdateWriteUsInformationDto updateWriteUsInformationDto)
        {
            string query = "Update WriteUsInformation Set Address=@address, Tel1=@tel1,Tel2=@tel2,Email=@email,AddressUrl=@addressUrl Where WriteUsInformationId=@writeUsInformationId";
            var parameters = new DynamicParameters();
            parameters.Add("@writeUsInformationId", updateWriteUsInformationDto.WriteUsInformationId);
            parameters.Add("@address", updateWriteUsInformationDto.Address);
            parameters.Add("@tel1", updateWriteUsInformationDto.Tel1);
            parameters.Add("@tel2", updateWriteUsInformationDto.Tel2);
            parameters.Add("@email", updateWriteUsInformationDto.Email);
            parameters.Add("@addressUrl", updateWriteUsInformationDto.Address);



            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }
    }
}
