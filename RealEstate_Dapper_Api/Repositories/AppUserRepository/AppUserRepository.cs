using Dapper;
using RealEstate_Dapper_Api.Dtos.AppUserDtos;
using RealEstate_Dapper_Api.Models.DapperContext;

namespace RealEstate_Dapper_Api.Repositories.AppUserRepository
{
    public class AppUserRepository : IAppUserRepository
    {
        private readonly Context _context;

        public AppUserRepository(Context context)
        {
            _context = context;
        }

        public async Task<GetAppUserByProductIdDto> GetAppUserByProductId(int id)
        {
            string query = "Select * From AppUser Where UserId=@userId";
           
            var parameters = new DynamicParameters();
            parameters.Add("@userId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetAppUserByProductIdDto>(query, parameters);
                return values;
            }
        }

        public async Task<GetAppUserByProductIdDto> GetAppUserByProductId2(int id)
        {
            string query = "select UserId,Name,PhoneNumber,UserImageUrl,Email from AppUser  inner join Product on Product.AppUserId = AppUser.UserId  where Product.ProductId=@productId";
            var parameters = new DynamicParameters();
            parameters.Add("@productId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetAppUserByProductIdDto>(query, parameters);
                return values;
            }
        }

        public async void CreateAppUser(CreateAppUserDto createAppUserDto)
        {
            string query = "insert into AppUser (UserName,Password,Name,Email,UserRole,UserImageUrl,PhoneNumber) values (@userName,@password,@name,@email,@userRole,@userImageUrl,@phoneNumber)";
            var paramaters = new DynamicParameters();
            paramaters.Add("@userName", createAppUserDto.UserName);
            paramaters.Add("@password", createAppUserDto.Password);
            paramaters.Add("@name", createAppUserDto.Name);
            paramaters.Add("@email", createAppUserDto.Email);
            paramaters.Add("@userRole", 2);
            paramaters.Add("@userImageUrl", createAppUserDto.UserImageUrl);
            paramaters.Add("@phoneNumber", createAppUserDto.PhoneNumber);

            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, paramaters);
            }
        }

        public async void DeleteAppUser(int id)
        {
            string query = "Delete From AppUser Where UserId=@userId";
            var parameters = new DynamicParameters();
            parameters.Add("@userId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultAppUserDto>> GetAllAppUserAsync()
        {
            string query = "Select * From AppUser";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultAppUserDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdAppUserDto> GetAppUser(int id)
        {
            string query = "Select * From AppUser Where UserId=@userId";
            var parameters = new DynamicParameters();
            parameters.Add("@userId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdAppUserDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateAppUser(UpdateAppUserDto updateAppUserDto)
        {
            //string query = "Update AppUser Set UserName=@UserName,Password=@password,Name=@name,Email=@email, UserRole = CASE WHEN @userRole IS NULL THEN UserRole ELSE @userRole END, UserImageUrl=@userImageUrl,PhoneNumber=@phoneNumber Where UserId=@userId";
            string query = "Update AppUser Set UserName=@UserName,Password=@password,Name=@name,Email=@email, UserRole=@userRole, UserImageUrl=@userImageUrl,PhoneNumber=@phoneNumber Where UserId=@userId";
            var parameters = new DynamicParameters();
            parameters.Add("@userId", updateAppUserDto.UserId);
            parameters.Add("@UserName", updateAppUserDto.UserName);
            parameters.Add("@password", updateAppUserDto.Password);
            parameters.Add("@name", updateAppUserDto.Name);
            parameters.Add("@email", updateAppUserDto.Email);
            parameters.Add("@userRole", updateAppUserDto.UserRole);
            parameters.Add("@userImageUrl", updateAppUserDto.UserImageUrl);
            parameters.Add("@phoneNumber", updateAppUserDto.PhoneNumber);


            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }

        }

    
    }
}
