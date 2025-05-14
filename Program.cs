namespace POO.ContentContext
{
    public class Program
    {
        static void Main(string[] args)
        {
            var curso = new Course();
            curso.Title = "Curso de C#";    

            Console.WriteLine(curso.Title);
        }
    }
}
