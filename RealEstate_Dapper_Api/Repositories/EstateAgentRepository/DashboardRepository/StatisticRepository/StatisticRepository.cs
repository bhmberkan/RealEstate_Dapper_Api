using Dapper;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.EstateAgentRepository.DashboardRepository.StatisticRepository
{
    public class StatisticRepository : IStatisticRepository
    {
        private readonly Context _context;

        public StatisticRepository(Context context)
        {
            _context = context;
        }

        public int AllProductCount()
        {
            string query = "Select Count(*) from Product";
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query);
                return values;
            }
        }

        public int ProductCountByEmployeeId(int id)
        {
            string query = "Select Count(*) from Product Where AppUserId=@appUserId";
            var paramaters = new DynamicParameters();
            paramaters.Add("@appUserId", id);
          
            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query,paramaters);
                return values;
            }
        }

        public int ProductCountByStatusFalse(int id)
        {
            string query = "Select Count(*) from Product Where AppUserId=@appUserId And  ProductStatus=0";
            var paramaters = new DynamicParameters();
            paramaters.Add("@appUserId", id);

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, paramaters);
                return values;
            }
        }

        public int ProductCountByStatusTrue(int id)
        {
            string query = "Select Count(*) from Product Where AppUserId=@appUserId And  ProductStatus=1";
            var paramaters = new DynamicParameters();
            paramaters.Add("@appUserId", id);

            using (var connection = _context.CreateConnection())
            {
                var values = connection.QueryFirstOrDefault<int>(query, paramaters);
                return values;
            }
        }
    }
}
