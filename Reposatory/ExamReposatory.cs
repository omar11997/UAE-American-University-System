using Microsoft.EntityFrameworkCore;
using UAE_American_University.Models;

namespace UAE_American_University.Reposatory
{
    public class ExamReposatory : IExamRepo
    {
        Context context;
        public ExamReposatory(Context context) 
        { 
            this.context = context;
        
        }
        public List<Exam> GetAllExams()
        {
           return context.Exams.ToList();   
        }

        public Exam GetExamById(int id)
        {
            return context.Exams.Include(e => e.Questions).FirstOrDefault(e => e.ID ==id);
        }
        public void SaveNewExam(Exam newexam)
        {
            context.Exams.Add(newexam);
            context.SaveChanges();  
            
        }
        public void DeleteExam(int id)
        {
            Exam? exam = context.Exams.FirstOrDefault(exam => exam.ID == id);    
            context.Exams.Remove(exam);
            context.SaveChanges();
        }
    }
}
