using UAE_American_University.Models;

namespace UAE_American_University.Reposatory
{
    public interface IStudentRepo
    {
        List<Student> GetAllStudents();
        Student GetStudentById(int id);
    }
}
