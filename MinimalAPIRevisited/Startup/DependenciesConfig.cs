using MinimalAPIRevisited.Data;

namespace MinimalAPIRevisited.Startup;

public static class DependenciesConfig
{
    public static void AddDependencies(this WebApplicationBuilder builder)
    {
        builder.Services.AddOpenApiService();
        builder.Services.AddTransient<CourseData>();
    }
}
