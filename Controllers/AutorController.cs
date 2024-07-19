using LibreriaPrueba.Dto;
using LibreriaPrueba.Models;
using LibreriaPrueba.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibreriaPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AutorController : ControllerBase
    {
        private readonly IAutorRepository _repository;

        public AutorController(IAutorRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("GetAllAutores")]
        public async Task<ActionResult> Get()
        {
            var autores = await _repository.getAllAsync();
            return Ok(autores);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Autor autordto)
        {
            var response = await _repository.createAutorAsync(autordto);
            return Ok(response);
        }
    }
}
