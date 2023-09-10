using UAE_American_University.Models;

namespace UAE_American_University.Reposatory
{
    public class QuestionReposatory : IQuestionRepo
    {
        Context context;
        public QuestionReposatory(Context context)
        {
            this.context = context;
        }
        //public void AddNewQuestion(int ID)
        //{
        //    Exam? exam = context.Exams.FirstOrDefault(e => e.ID == ID);
        //}

        public void SaveNewQuestion(Question newQuestion)
        {
            context.Questions.Add(newQuestion);
            context.SaveChanges();  
        }
    }
}
