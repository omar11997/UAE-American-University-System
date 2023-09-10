using UAE_American_University.Models;

namespace UAE_American_University.Reposatory
{
    public interface IExamRepo
    {
        List<Exam> GetAllExams();
        Exam GetExamById(int id);
        void DeleteExam(int id);

       void SaveNewExam(Exam newexam);
    }
}
