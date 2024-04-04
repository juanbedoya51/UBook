namespace UBook.Data
{
    public class Libro
    {
        public int ID { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string autor { get; set; } = string.Empty;
        public string editorial { get; set; } = string.Empty;
        public string genero { get; set; } = string.Empty;
        public string idioma { get; set; } = string.Empty;
        public int nopagina { get; set; }
        public string issn { get; set; } = string.Empty;
        public DateOnly fecha { get; set; }
        public decimal precio { get; set; }
        public string estado { get; set; } = string.Empty;
        public string imagen { get; set; } = string.Empty;
        public int nuevo { get; set; }
    }
}
