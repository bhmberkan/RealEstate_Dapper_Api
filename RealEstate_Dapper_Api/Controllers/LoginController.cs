using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.LoginDtos;
using RealEstate_Dapper_Api.Models.DapperContext;
using RealEstate_Dapper_Api.Tools;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly Context _context;

        public LoginController(Context context)
        {
            _context = context;
        }


        [HttpPost]
        public async Task<IActionResult> SignIn(CreateLoginDto loginDto)
        {
            string query = "Select * From AppUser Where UserName=@username and Password=@password";
            string query2 = "Select UserId From AppUser Where UserName=@username and Password=@password";
            var parameters = new DynamicParameters();
            parameters.Add("@username", loginDto.UserName);
            parameters.Add("password", loginDto.Password);
            
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryFirstOrDefaultAsync<CreateLoginDto>(query, parameters);
                var values2 = await connection.QueryFirstOrDefaultAsync<GetAppUserIdDto>(query2, parameters);
                if (values != null)
                {
                    GetCheckAppUserViewModel model = new GetCheckAppUserViewModel();
                    model.UserName = values.UserName;
                    model.Id = values2.UserId;
                    var token = JwtTokenGenerator.GenerateToken(model);
                    return Ok(token);
                }
                return Ok("Başarısız");
            }
        }
    }
}
