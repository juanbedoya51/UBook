namespace UBook.Data
{
    public class Tarjeta
    {
        public int id_tarjeta {  get; set; }
        public int id_usuario {  get; set; }
        public string numero { get; set; } = string.Empty;
        public string fecha_vencimiento { get; set; } = string.Empty;
        public string titular { get; set; } = string.Empty;
        public int saldo { get; set; }
        public int cvc { get; set; }
    }
}
