using LibreriaPrueba.Models;
using LibreriaPrueba.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LibreriaPrueba.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LibroController : ControllerBase
    {
        private readonly ILibroRepository _repository;

        public LibroController(ILibroRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var libros = await _repository.getAllAsync();
            return Ok(libros);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(int ISBN)
        {
            var delete = await _repository.deleteLibroAsync(ISBN);
            return Ok(delete);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] Libro libroDto)
        {
            var response = await _repository.createLibroAsync(libroDto);
            return Ok(response);
        }

        [HttpPut]
        public async Task<ActionResult> Update( int id, [FromBody] Libro librodto)
        {
            var update = await _repository.updateLibroAsync(librodto, id);
            return Ok(update);
        }
    }
}
