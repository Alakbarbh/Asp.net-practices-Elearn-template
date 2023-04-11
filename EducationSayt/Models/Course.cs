namespace EducationSayt.Models
{
    public class Course : BaseEntity 
    {
        public string? Price { get; set; }
        public string? Header { get; set; }
        public string? Description { get; set; }
        public string? Sales { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public ICollection<CourseImage> CourseImages { get; set; }
    }
}
