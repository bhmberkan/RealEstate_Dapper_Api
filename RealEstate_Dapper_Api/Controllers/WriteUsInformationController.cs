using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.WriteUsInformationDtos;
using RealEstate_Dapper_Api.Repositories.WriteUsInformationRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WriteUsInformationController : ControllerBase
    {
        private readonly IWriteUsInformationRepository _writeUsInformationRepository;

        public WriteUsInformationController(IWriteUsInformationRepository writeUsInformationRepository)
        {
            _writeUsInformationRepository = writeUsInformationRepository;
        }
        [HttpGet]
        public async Task<IActionResult> WriteUsInformationList()
        {
            var values = await _writeUsInformationRepository.GetAllWriteUsInformationAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateWriteUsInformation(CreateWriteUsInformationDto createWriteUsInformationDto)
        {
            _writeUsInformationRepository.CreateWriteUsInformation(createWriteUsInformationDto);
            return Ok("Hakkımızda Açıklama Alanı Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWriteUsInformation(int id)
        {
            _writeUsInformationRepository.DeleteWriteUsInformation(id);
            return Ok("Hakkımızda Açıklama Alanı Silme işlemi başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateWriteUsInformation(UpdateWriteUsInformationDto updateWriteUsInformationDto)
        {
            _writeUsInformationRepository.UpdateWriteUsInformation(updateWriteUsInformationDto);
            return Ok("Hakkımızda Açıklama Alanı Güncelleme işlemi Başarılı.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetWriteUsInformation(int id)
        {
            var value = await _writeUsInformationRepository.GetWriteUsInformation(id);
            return Ok(value);
        }

    }
}
