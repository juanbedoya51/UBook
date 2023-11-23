namespace UBook.Data
{
    public class Cuenta
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public DateTime fecha_nacimiento { get; set; }
        public string contrasena { get; set; }
        public string pregunta { get; set; }
        public string respuesta { get; set;}
        public string DireccionEnvio { get; set; }
        public string telefono { get; set; }

    }
}
