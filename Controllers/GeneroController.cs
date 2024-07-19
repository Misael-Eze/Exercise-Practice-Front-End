using LibreriaPrueba.Dto;
using LibreriaPrueba.Models;
using LibreriaPrueba.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace LibreriaPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GeneroController : ControllerBase
    {
        private readonly IGeneroRepository _repository;

        public GeneroController(IGeneroRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var generos = await _repository.getAllAsync();
            return Ok(generos);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Genero dto)
        {
            var response = await _repository.createGeneroAsync(dto);
            return Ok(response);
        }
    }
}
