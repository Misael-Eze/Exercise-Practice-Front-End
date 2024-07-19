using System.ComponentModel.DataAnnotations;

namespace LibreriaPrueba.Models
{
    public class Autor
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public Autor()
        {
            Id = 0;
            Nombre = string.Empty;
            FechaNacimiento = DateTime.Now;
        }
    }
}
