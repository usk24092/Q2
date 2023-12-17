using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;

namespace StudentMan.Pages
{
    public class PrivacyModel : PageModel
    {
        public List<StudentView> Students = new List<StudentView>();

        public void OnGet()
        {
            try
            {
                string connectionString = "Data Source=.\\sqlexpress;Initial Catalog=StudentMan;Integrated Security=true;Connect Timeout=300;Encrypt=False;Trust Server Certificate=true;Application Intent=ReadWrite;Multi Subnet Failover=False";
            using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "select Student_Id, name, City, CourseID from Student";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                StudentView student = new StudentView();
                                student.Student_Id = reader.GetInt32(0);
                                student.Name = reader.GetString(1);
                                student.City = reader.GetString(2);
                                student.CourseID = reader.GetInt32(3);
                                
                                Students.Add(student);
                            }
                        }
                    }
                }
            }
            catch(Exception ex)
            {

            }
        }


    }

    public class StudentView
    {
        public int Student_Id;
        public string Name;
        public string City;
        public int CourseID;
    }

}
