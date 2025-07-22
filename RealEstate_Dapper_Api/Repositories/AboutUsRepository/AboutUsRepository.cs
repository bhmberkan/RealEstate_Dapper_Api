using Dapper;
using RealEstate_Dapper_Api.Dtos.AboutUsDtos;
using RealEstate_Dapper_Api.Models.DapperContext;
using System.Reflection.Metadata;

namespace RealEstate_Dapper_Api.Repositories.AboutUsRepository
{
    public class AboutUsRepository : IAboutUsRepository
    {
        private readonly Context _context;

        public AboutUsRepository(Context context)
        {
            _context = context;
        }

        public async void CreateAboutUs(CreateAboutUsDto createAboutUsDto)
        {
            string query = "insert into AboutUs (Title,SubTitle,Description1,Description2,Image,VideoTitle,VideoUrl) values (@title,@subtitle,@description1,@description2,@image,@videotitle,@videourl)";
            var paramaters = new DynamicParameters();
            paramaters.Add("@title", createAboutUsDto.Title);
            paramaters.Add("@subtitle", createAboutUsDto.SubTitle);
            paramaters.Add("@description1", createAboutUsDto.Description1);
            paramaters.Add("@description2", createAboutUsDto.Description2);
            paramaters.Add("@image", createAboutUsDto.Image);
            paramaters.Add("@videotitle", createAboutUsDto.VideoTitle);
            paramaters.Add("@videourl", createAboutUsDto.VideoUrl);
           
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, paramaters);
            }
        }

        public async void DeleteAboutUs(int id)
        {
            string query = "Delete From AboutUs Where AboutUsId=@aboutUsId";
            var parameters = new DynamicParameters();
            parameters.Add("@aboutUsId", id);
            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }
        }

        public async Task<List<ResultAboutUsDto>> GetAllAboutUsAsync()
        {
            string query = "Select * From AboutUs";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultAboutUsDto>(query);
                return values.ToList();
            }
        }

        public async Task<GetByIdAboutUsDto> GetAboutUs(int id)
        {
            string query = "Select * From AboutUs Where AboutUsId=@aboutUsId";
            var parameters = new DynamicParameters();
            parameters.Add("@aboutUsId", id);
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<GetByIdAboutUsDto>(query, parameters);
                return values;
            }
        }

        public async void UpdateAboutUs(UpdateAboutUsDto updateAboutUsDto)
        {
            string query = "Update AboutUs Set Title=@title, SubTitle=@subtitle,Description1=@description1,Description2=@description2,Image=@image, VideoTitle=@videotitle, VideoUrl=@videourl Where AboutUsId=@AboutUsId";
            var parameters = new DynamicParameters();
            parameters.Add("@AboutUsId",updateAboutUsDto.AboutUsId);
            parameters.Add("@title", updateAboutUsDto.Title);
            parameters.Add("@subtitle", updateAboutUsDto.SubTitle);
            parameters.Add("@description1", updateAboutUsDto.Description1);
            parameters.Add("@description2", updateAboutUsDto.Description2);
            parameters.Add("@image", updateAboutUsDto.Image);
            parameters.Add("@videotitle", updateAboutUsDto.VideoTitle);
            parameters.Add("@videourl", updateAboutUsDto.VideoUrl);


            using (var connection = _context.CreateConnection())
            {
                await connection.ExecuteAsync(query, parameters);
            }

        }
    }
}
