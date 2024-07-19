using LibreriaPrueba.Context;
using LibreriaPrueba.Dto;
using LibreriaPrueba.Models;
using Microsoft.EntityFrameworkCore;

namespace LibreriaPrueba.Repositories.RepositoriesImpl
{
    public class GeneroRepository : IGeneroRepository
    {
        private readonly LibreriaDbContext _context;

        public GeneroRepository(LibreriaDbContext context)
        {
            _context = context;
        }
        public async Task<Genero> createGeneroAsync(Genero genero)
        {
            await _context.Generos.AddAsync(genero);
            await _context.SaveChangesAsync();
            return genero;
        }

        public async Task<List<Genero>> getAllAsync()
        {
            return await _context.Generos.ToListAsync();
        }
    }
}
