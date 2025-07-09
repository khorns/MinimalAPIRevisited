using MinimalAPIRevisited.Data;

namespace MinimalAPIRevisited.Endpoints;

public static class CourseEndpoints
{
    public static void AddCourseEndpoint(this WebApplication app)
    {
        app.MapGet("/courses", GetCoursed);
        app.MapGet("/courses/{id}", GetCourseById);
    }

    private static async Task<IResult> GetCoursed(CourseData data, string? courseType, string? search, int? delay)
    {
        var output = data.Courses;

        if (string.IsNullOrWhiteSpace(courseType) == false)
        {
            output = output.Where(c => c.courseType.Equals(courseType, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        
        if (string.IsNullOrWhiteSpace(search) == false)
        {
            output = output.FindAll(c => c.courseName.Contains(search, StringComparison.OrdinalIgnoreCase) &&
                                         c.shortDescription.Contains(search, StringComparison.OrdinalIgnoreCase));
        }

        if (delay.HasValue && delay > 0)
        {
            await Task.Delay(delay.Value);
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
