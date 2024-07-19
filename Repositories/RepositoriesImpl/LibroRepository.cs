using LibreriaPrueba.Context;
using LibreriaPrueba.Models;
using Microsoft.EntityFrameworkCore;

namespace LibreriaPrueba.Repositories.RepositoriesImpl
{
    public class LibroRepository : ILibroRepository
    {
        private readonly LibreriaDbContext _context;
        public LibroRepository(LibreriaDbContext context)
        {
            _context = context;
        }
        public async Task<Libro> createLibroAsync(Libro libro)
        {
            await _context.Libros.AddAsync(libro);
            await _context.SaveChangesAsync();
            return libro;
        }

        public async Task<Libro> deleteLibroAsync(int id)
        {
            var borrar = await _context.Libros.FindAsync(id);
            if (borrar == null)
            {
                return null;
            }
            _context.Remove(borrar);
            await _context.SaveChangesAsync();
            return borrar;
        }

        public async Task<List<Libro>> getAllAsync()
        {
            return await _context.Libros.ToListAsync();
        }

        public async Task<Libro> updateLibroAsync(Libro libro, int id)
        {
            var actualizacion = await _context.Libros.FindAsync(id);
            if (actualizacion == null)
            {
                return null;
            }
            _context.Entry(actualizacion).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return actualizacion;
        }
    }
}
