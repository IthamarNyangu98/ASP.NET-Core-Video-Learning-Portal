namespace CareProLearning.Models
{
    public class Module
    {
        public int ModuleId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? VideoUrl { get; set; }
        public string? ThumbnailImagePath { get; set; }
        public string? Category { get; set; }
        public double ProgressInSeconds { get; set; }
        public bool IsCompleted { get; set; }
        public double LengthInSeconds { get; set; }

    }
}
