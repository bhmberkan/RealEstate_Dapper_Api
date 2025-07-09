using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.ToDoLitRepository;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListsController : ControllerBase
    {
        private readonly IToDoLitRepository _toDoLitRepository;

        public ToDoListsController(IToDoLitRepository toDoLitRepository)
        {
            _toDoLitRepository = toDoLitRepository;
        }

        [HttpGet]
        public async Task<IActionResult> ToDoListList()
        {
            var values = await _toDoLitRepository.GetAllToDoListAsync();
            return Ok(values);
        }
    }
}
