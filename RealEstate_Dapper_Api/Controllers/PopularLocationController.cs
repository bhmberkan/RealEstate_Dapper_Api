using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.PopularLocationRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationController : ControllerBase
    {
        private readonly IPopularLocationRepository _opularLocationRepository;

        public PopularLocationController(IPopularLocationRepository opularLocationRepository)
        {
            _opularLocationRepository = opularLocationRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetPopularLocationList()
        {
            var values = await _opularLocationRepository.GetAllPopularLocationAsync();
            return Ok(values);
        }
    }
}
