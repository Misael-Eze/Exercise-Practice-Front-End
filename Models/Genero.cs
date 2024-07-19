using System.ComponentModel.DataAnnotations;

namespace LibreriaPrueba.Models
{
    public class Genero
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Genero()
        {
            Id = 0;
            Nombre = string.Empty;
        }
    }
}
