using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Dtos.ContactDtos;
using RealEstate_Dapper_Api.Repositories.ContactRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactRepository _contactRepository;

        public ContactsController(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }


        [HttpGet]
        public async Task<IActionResult> ContactList()
        {
            var values = await _contactRepository.GetAllContactAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDto createContactDto)
        {
            _contactRepository.CreateContact(createContactDto);
            return Ok("Mesaj Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContact(int id)
        {
            _contactRepository.DeleteContact(id);
            return Ok("Mesaj Silme işlemi başarılı");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateContact(UpdateContactDto updateContactDto)
        {
            _contactRepository.UpdateContact(updateContactDto);
            return Ok("Mesaj Güncelleme işlemi Başarılı.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContact(int id)
        {
            var value = await _contactRepository.GetContact(id);
            return Ok(value);
        }

        [HttpGet("GetLast4Contact")]
        public async Task<IActionResult> GetLast4Contact()
        {
            var values = await _contactRepository.GetLast4Contact();
            return Ok(values);
        }
    }
}
