namespace UBook.Data
{
    public class Venta
    {
        public int ID { get; set; }
        public DateTime FechaCompra { get; set; }
        public Cuenta Cliente { get; set; }
        public Libro Libro { get; set; }
        // Agrega más propiedades según tus necesidades
    }
}
