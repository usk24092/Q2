using System.ComponentModel.DataAnnotations;

namespace StudentMan.Model
{
    public class Student
    {
        [Key] public int Student_Id { get; set; }
        public string Name { get; set;}
        public string City { get; set; }
        public int CourseID { get; set; }
    }
}
