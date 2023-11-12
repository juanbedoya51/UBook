namespace UBook.Data
{
    public class Libro
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string autor { get; set; }
        public string editorial { get; set; }
        public string genero { get; set; }
        public string idioma { get; set; }
        public int nopagina { get; set; }
        public string issn { get; set; }
        public DateTime fecha { get; set; }
        public decimal precio { get; set; }
        public int vendido { get; set; }
        public string imagen { get; set; }
    }
}
