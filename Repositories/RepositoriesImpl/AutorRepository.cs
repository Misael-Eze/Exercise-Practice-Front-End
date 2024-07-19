using LibreriaPrueba.Context;
using LibreriaPrueba.Models;
using Microsoft.EntityFrameworkCore;

namespace LibreriaPrueba.Repositories.RepositoriesImpl
{
    public class AutorRepository : IAutorRepository
    {
        private readonly LibreriaDbContext _context;

        public AutorRepository(LibreriaDbContext context)
        {
            _context = context;
        }
        public async Task<Autor> createAutorAsync(Autor autor)
        {
            await _context.Autores.AddAsync(autor);
            await _context.SaveChangesAsync();
            return autor;
        }

        public async Task<List<Autor>> getAllAsync()
        {
            return await _context.Autores.ToListAsync();
        }
    }
}
