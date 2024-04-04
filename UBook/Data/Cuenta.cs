namespace UBook.Data
{
    public class Cuenta
    {
        public int ID { get; set; }
        public string dni { get; set; } = string.Empty;
        public string nombre { get; set; } = string.Empty;
        public string apellido { get; set; } = string.Empty;
        public string correo { get; set; } = string.Empty;
        public DateOnly fecha_nacimiento { get; set; }
        public string lugar_nacimiento { get; set; } = string.Empty;
        public string contrasena { get; set; } = string.Empty;
        public string direccion { get; set; } = string.Empty;
        public string genero { get; set; } = string.Empty;
        public List<string> preferencias { get; set; }
        public string telefono { get; set; } = string.Empty;
        public string usuario {  get; set; } = string.Empty;

    }
}
