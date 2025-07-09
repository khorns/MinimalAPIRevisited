using Scalar.AspNetCore;

namespace MinimalAPIRevisited.Startup
{
    public static class OpenApiConfig
    {
        public static void AddOpenApiService(this IServiceCollection Services)
        {
            Services.AddOpenApi();
        }

        public static void UseOpenApi(this WebApplication app)
        {
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
                app.MapScalarApiReference(options =>
                {
                    options.Title = "The sampel API";
                    options.Theme = ScalarTheme.Saturn;
                });
            }
        }
    }
}
