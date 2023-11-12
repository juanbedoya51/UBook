namespace UBook.Data
{
    public class Respuesta<T>
    {
        public string status { get; set; }
        public string message { get; set; }
        public T data { get; set; }
    }
}
