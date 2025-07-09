using MinimalAPIRevisited.Data;

namespace MinimalAPIRevisited.Endpoints;

public static class CourseEndpoints
{
    public static void AddCourseEndpoint(this WebApplication app)
    {
        app.MapGet("/courses", GetCoursed);
        app.MapGet("/courses/{id}", GetCourseById);
    }

    private static IResult GetCoursed(CourseData data, string? courseType, string? search, int? delay)
    {
        var output = data.Courses;


        if (output == null)
        {
            return Results.NotFound();
        }

        return Results.Ok(output);
    }

    private static IResult GetCourseById(CourseData data, int id)
    {
        var output = data.Courses.SingleOrDefault(c => c.Id == id);

        if (output == null)
        {
            return Results.NotFound();
        }

        return Results.Ok(output);
    }
}
