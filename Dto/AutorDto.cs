namespace LibreriaPrueba.Dto
{
    public class AutorDto
    {
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }

        public AutorDto()
        {
            Nombre = string.Empty;
            FechaNacimiento = DateTime.Now;
        }
    }
}
