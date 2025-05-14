namespace POO.ContentContext
{
    public abstract class Content //classes abstradas nao podem ser instanciadas.
    {
        public Content()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
