namespace MinimalAPIRevisited.Model
{
    public class CourseModel
    {
        public int Id { get; set; }
        public bool IsPreorder { get; set; }
        public required string courseUrl { get; set; }
        public required string courseType { get; set; }
        public required string courseName { get; set; }
        public int CourseLessonCount { get; set; }
        public float CourseLengthInHours { get; set; }
        public required string shortDescription { get; set; }
        public required string courseImage { get; set; }
        public int PriceInUSD { get; set; }
        public required string coursePreviewLink { get; set; }
    }
}
