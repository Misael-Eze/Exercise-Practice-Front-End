using LibreriaPrueba.Models;
using Microsoft.EntityFrameworkCore;

namespace LibreriaPrueba.Context
{
    public class LibreriaDbContext : DbContext
    {
        public LibreriaDbContext(DbContextOptions dbContextOptions) 
            : base(dbContextOptions)
        {

        }

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Autor> Autores { get; set; }
        public DbSet<Genero> Generos { get; set; }

    }
}
