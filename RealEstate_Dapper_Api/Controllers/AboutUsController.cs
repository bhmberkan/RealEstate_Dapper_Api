using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.AboutUsDtos;
using RealEstate_Dapper_Api.Repositories.AboutUsRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IAboutUsRepository _aboutUsRepository;

        public AboutUsController(IAboutUsRepository aboutUsRepository)
        {
            _aboutUsRepository = aboutUsRepository;
        }

        [HttpGet]
        public async Task<IActionResult> AboutUsList()
        {
            var values = await _aboutUsRepository.GetAllAboutUsAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAboutUs(CreateAboutUsDto createAboutUsDto)
        {
            _aboutUsRepository.CreateAboutUs(createAboutUsDto);
            return Ok("Kategory Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAboutUs(int id)
        {
            _aboutUsRepository.DeleteAboutUs(id);
            return Ok("Kategory Silme işlemi başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAboutUs(UpdateAboutUsDto updateAboutUsDto)
        {
            _aboutUsRepository.UpdateAboutUs(updateAboutUsDto);
            return Ok("AboutUs Güncelleme işlemi Başarılı.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutUs(int id)
        {
            var value = await _aboutUsRepository.GetAboutUs(id);
            return Ok(value);
        }
        // Bunları yazmış olsam da UI da sadece Güncellemeyi kullanmayı düşünüyorum. Sadece 1 Alan olacak
    }
}
