namespace POO.ContentContext
{
    public class Program
    {
        static void Main(string[] args)
        {
            var articles = new List<Article>();
            articles.Add(new Article("Artigo sobre OOP", "orienteção-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre .NET", "dotnet"));

            foreach (var article in articles)
            {
                Console.WriteLine("Id", article.Id);
                Console.WriteLine("Titulo:", article.Title);
                Console.WriteLine("Artigos:", article.Url);
            }
        }
    }
}
