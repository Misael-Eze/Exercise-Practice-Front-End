using LibreriaPrueba.Models;

namespace LibreriaPrueba.Repositories
{
    public interface ILibroRepository
    {
        Task<List<Libro>> getAllAsync();
        Task<Libro> createLibroAsync(Libro libro);   
        Task<Libro> updateLibroAsync(Libro libro, int id);
        Task<Libro> deleteLibroAsync(int id);    
    }
}
