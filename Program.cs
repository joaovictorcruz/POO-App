namespace POO.ContentContext
{
    public class Program
    {
        static void Main(string[] args)
        {
            var curso = new Course();
            curso.Title = "Curso de C#";    

            Console.WriteLine(curso.Title);

            var career = new Career();
            career.Items.Add(new CareerItem());
            Console.WriteLine(career.TotalCourses);
        }
    }
}
