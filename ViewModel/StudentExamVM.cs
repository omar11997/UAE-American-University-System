using UAE_American_University.Models;

namespace UAE_American_University.ViewModel
{
    public class StudentExamVM
    {
        public string? StudentName { get; set; } 

        public int StudentId { get; set; }

        public int ExamId { get; set; }

        public string? ExamName { get; set; }

        public string? CourseName { get; set; }

        public int Year { get; set; }

        public List<Question>? Questions { get; set; } = new List<Question>();

        public List<string> Answers { get; set; } = new List<string>();

    }
}
