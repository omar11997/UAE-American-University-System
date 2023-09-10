using Microsoft.AspNetCore.Mvc;
using UAE_American_University.Models;
using UAE_American_University.Reposatory;
using UAE_American_University.ViewModel;

namespace UAE_American_University.Controllers
{
	public class StudentController : Controller
	{


		
		IStudentRepo studentRepo;
        IExamRepo examRepo;
        public StudentController(IStudentRepo studentRep, IExamRepo examRep) 
		{ 
			studentRepo = studentRep;
            examRepo = examRep;	
		}
		public IActionResult GetAllStudents()
		{
			List<Student> AllStudents = studentRepo.GetAllStudents(); 

			return View(AllStudents);
		}
		public IActionResult ShowStudentPage()
		{
			return View();
		}
        public IActionResult GetReadyExams()
		{
            List<Exam> AllExams = examRepo.GetAllExams();
			return View(AllExams);
        }
		public IActionResult ShowExam(int ID )
		{
			Exam exam = examRepo.GetExamById(ID);
			StudentExamVM studentExamVM = new StudentExamVM();
			studentExamVM.ExamId = exam.ID;
			studentExamVM.ExamName = exam.Name;
			studentExamVM.CourseName = exam.CourseName;	
			studentExamVM.Questions = exam.Questions;
			studentExamVM.Year = exam.Year;
			
		
			return View(studentExamVM);
		}
		[HttpPost]
		public IActionResult SubmitExam(StudentExamVM studentExamVM)
		{
			List<string> answers = studentExamVM.Answers.ToList();
            Exam exam = examRepo.GetExamById(2);
            return View();
		}
		public IActionResult GetStudentResult()
		{
			return View();
		}
		[HttpPost]
		public IActionResult ShowStudentResults(int id)
		{
			Student? student = studentRepo.GetStudentById(id);
			if (student == null)
			{
				return RedirectToAction("GetStudentResult");
			}

            return View(student);
		}
    }
}
