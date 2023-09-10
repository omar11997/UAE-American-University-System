using Microsoft.EntityFrameworkCore;
using UAE_American_University.Models;

namespace UAE_American_University.Reposatory
{
    public class StudentRepo : IStudentRepo
    {
        Context Context;
        public StudentRepo(Context context) { 
            this.Context = context; 
        }
        public List<Student> GetAllStudents()
        {
            return Context.Students.ToList();
        }

        public Student GetStudentById(int id)
        {
            
            return Context.Students.Include(e => e.Exams).FirstOrDefault(e => e.ID == id);
        }
    }
}
