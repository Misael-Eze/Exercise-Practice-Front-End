using LibreriaPrueba.Dto;
using LibreriaPrueba.Models;

namespace LibreriaPrueba.Repositories
{
    public interface IGeneroRepository
    {
        Task<List<Genero>> getAllAsync();
        Task<Genero> createGeneroAsync(Genero genero);
    }
}
