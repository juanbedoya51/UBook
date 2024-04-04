namespace UBook.Data
{
    public class ComprarL
    {
        public int id_usuario { get; set; }
        public int id_tarjeta { get; set; }
        public int id_libro { get; set; }
        public int id_direccion { get; set; }
    }

    public class ComprarR
    {
        public int id_historico { get; set; }
        public int id_usuario { get; set; }
        public int id_libro { get; set; }
        public string nombre_libro { get; set; }
        public string compra_cancelada { get; set; }
        public string estado_envio { get; set; }
        public DateOnly fecha_compra { get; set; }
        public int id_tarjeta { get; set; }
        public string direccion { get; set; } = string.Empty;
        public string imagen { get; set; } = string.Empty;
        public decimal precio { get; set; }
        public int nuevo {  get; set; }
    }
}
