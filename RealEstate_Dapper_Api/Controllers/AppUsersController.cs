using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.AppUserDtos;
using RealEstate_Dapper_Api.Repositories.AppUserRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUsersController : ControllerBase
    {
        private readonly IAppUserRepository _appUserRepository;

        public AppUsersController(IAppUserRepository appUserRepository)
        {
            _appUserRepository = appUserRepository;
        }

        

        [HttpGet("AppUserList")]
        public async Task<IActionResult> AppUserList()
        {
            var values = await _appUserRepository.GetAllAppUserAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAppUser(CreateAppUserDto createAppUserDto)
        {
            _appUserRepository.CreateAppUser(createAppUserDto);
            return Ok("Kullanıcı Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAppUser(int id)
        {
            _appUserRepository.DeleteAppUser(id);
            return Ok("Kullanıcı Silme işlemi başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAppUser(UpdateAppUserDto updateAppUserDto)
        {
            _appUserRepository.UpdateAppUser(updateAppUserDto);
            return Ok("Kullanıcı Güncelleme işlemi Başarılı.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAppUser(int id)
        {
            var value = await _appUserRepository.GetAppUser(id);
            return Ok(value);
        }

        [HttpGet]
        public async Task<IActionResult> GetAppUserByProductId(int id)
        {
            var value = await _appUserRepository.GetAppUserByProductId(id);
            return Ok(value);
        }

        [HttpGet("GetAppUserByProductId2")]
        public async Task<IActionResult> GetAppUserByProductId2(int id)
        {
            var value = await _appUserRepository.GetAppUserByProductId2(id);
            return Ok(value);
        }
    }
}
