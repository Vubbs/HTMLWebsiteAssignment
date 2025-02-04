namespace HTML_Assignment_1_Ex_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.UseFileServer();
            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
