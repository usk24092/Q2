using System.ComponentModel.DataAnnotations;

namespace StudentMan.Model
{
    public class Course
    {
        [Key] public int CourseID { get; set; }
        public string Name { get; set; }
        public string LectureName { get; set; }
    }
}
