using LibreriaPrueba.Models;

namespace LibreriaPrueba.Repositories
{
    public interface IAutorRepository
    {
        Task<List<Autor>> getAllAsync();
        Task<Autor> createAutorAsync(Autor autor);
    }
}
