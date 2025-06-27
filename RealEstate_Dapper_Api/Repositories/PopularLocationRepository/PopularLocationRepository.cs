using Dapper;
using RealEstate_Dapper_Api.Dtos.CategoryDtos;
using RealEstate_Dapper_Api.Dtos.PopularLocationDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.PopularLocationRepository
{
    public class PopularLocationRepository : IPopularLocationRepository
    {
        private readonly Context _context;

        public PopularLocationRepository(Context context)
        {
            _context = context;
        }

        public void CreatePopularLocation(CreatePopularLocationDto createPopularLocationDto)
        {
            throw new NotImplementedException();
        }

        public void DeletePopularLocation(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultPopularLocationDto>> GetAllPopularLocationAsync()
        {
            string query = "Select * From PopularLocation";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultPopularLocationDto>(query);
                return values.ToList();
            }
        }

        public Task<GetByIdPopularLocationDto> GetPopularLocation(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdatePopularLocation(UpdatePopularLocationDto updatePopularLocationDto)
        {
            throw new NotImplementedException();
        }
    }
}
