namespace LibreriaPrueba.Dto
{
    public class LibroDto
    {
        public string Titulo { get; set; }
        public AutorDto Autor { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public GeneroDto Genero { get; set; }

        public LibroDto()
        {
            Titulo = string.Empty;  
            Autor = new AutorDto();
            FechaPublicacion = DateTime.Now;
            Genero = new GeneroDto();
        }
    }
}
