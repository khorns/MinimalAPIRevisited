
using MinimalAPIRevisited.Endpoints;
using MinimalAPIRevisited.Startup;

namespace MinimalAPIRevisited;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();

        builder.AddDependencies();

        var app = builder.Build();

        app.UseOpenApi();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        // Add Endpoint
        app.AddRootEndpoints();
        app.AddCourseEndpoint();

        app.Run();
    }
}
