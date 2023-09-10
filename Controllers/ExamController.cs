using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UAE_American_University.Models;
using UAE_American_University.Reposatory;
using UAE_American_University.ViewModel;

namespace UAE_American_University.Controllers
{
    public class ExamController : Controller
    {
        
        IExamRepo examRepo;
        public ExamController(IExamRepo examRep)
        {
            examRepo = examRep;
        }
        public IActionResult GetAllExams()
        {
            List<Exam> AllExams = examRepo.GetAllExams(); 
            return View(AllExams);
        }
        public IActionResult AddNewExam()
        {

            return View();
           
        }
       
        [HttpPost]
        public IActionResult SaveNewExam(Exam newexam)
        {
            examRepo.SaveNewExam(newexam);
           

            return RedirectToAction("GetAllExams");
        }
        public IActionResult GetExamById(int id) {
            Exam? exam = examRepo.GetExamById(id);


            return View(exam);
        }
        public IActionResult DeleteExam(int id )
        {
            examRepo.DeleteExam(id);
           
            return RedirectToAction("GetAllExams");
        }

    }
}
