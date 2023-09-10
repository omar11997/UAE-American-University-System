using System.Collections;
using Microsoft.AspNetCore.Mvc;
using UAE_American_University.Models;
using UAE_American_University.Reposatory;
using UAE_American_University.ViewModel;

namespace UAE_American_University.Controllers
{
    public class QuestionController : Controller
    {
     
        IExamRepo examRepo;
        IQuestionRepo questionRepo;
        public QuestionController(IExamRepo examRep, IQuestionRepo questionRepo)
        {
            examRepo = examRep;
            this.questionRepo = questionRepo;
        }
        public IActionResult AddNewQuestion(int ID)
        {
            Exam? exam = examRepo.GetExamById(ID); 
            ViewData["examName"] = exam.Name;
            ViewData["ID"] = ID;
            return View();
        }
        [HttpPost]
        public IActionResult SaveNewQuestion(Question newQuestion, int ExamId)
        {
            Exam? exam = examRepo.GetExamById(ExamId); 
            exam.Questions.Add(newQuestion);
            questionRepo.SaveNewQuestion(newQuestion);
            
            return RedirectToAction("AddNewQuestion", new {ID = ExamId });
        }

    }
}
