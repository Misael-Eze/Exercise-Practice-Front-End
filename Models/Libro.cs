using System.ComponentModel.DataAnnotations;

namespace LibreriaPrueba.Models
{
    public class Libro
    {
        [Key]
        public int ISBN { get; set; }
        public string Titulo { get; set; }
        public Autor Autor { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public Genero Genero { get; set; }

        public Libro()
        {
            ISBN = 0;
            Titulo = string.Empty;
            Autor = new Autor();
            FechaPublicacion = DateTime.Now;
            Genero = new Genero();
        }
    }
}
