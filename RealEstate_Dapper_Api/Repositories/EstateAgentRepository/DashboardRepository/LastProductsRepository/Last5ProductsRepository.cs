using Dapper;
using Microsoft.AspNetCore.Mvc.Formatters;
using RealEstate_Dapper_Api.Dtos.ProductDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.EstateAgentRepository.DashboardRepository.LastProductsRepository
{
    public class Last5ProductsRepository : ILast5ProductsRepository
    {
        private readonly Context _context;

        public Last5ProductsRepository(Context context)
        {
            _context = context;
        }

        public async Task<List<ResultLast5ProductWithCategoryDto>> GetLast5ProductAsync(int id)
        {
            string query = "Select Top(5) ProductId,Title,Price,City,District,ProductCategory,CategoryName,AdvertisementDate From Product Inner Join Category On Product.ProductCategory=Category.CategoryID Where AppUserId=@appUserId Order By ProductID Desc";
            var parameters = new DynamicParameters();
            parameters.Add("@appUserId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultLast5ProductWithCategoryDto>(query, parameters);
                return values.ToList();
            }
        }
    }
}
