using System.ComponentModel.DataAnnotations.Schema;

namespace UAE_American_University.Models
{
	public class StudentExam
	{
        private static int nextId = 1;
        public StudentExam()
        {
            ID = nextId;
            nextId++;
        }
        public int ID { get; set; }

		public int FinalDegree { get; set; }
		public bool IsPass { get; set; }
		[ForeignKey("Student")]
		public int StudentId { get; set; }
        public string? CourseName { get; set; }
		public List<string> Asnwers { get; set; } = new List<string>();
        public virtual Student? Student { get; set; }
		[ForeignKey("Exam")]
		public int ExamId { get; set; }	

		public virtual Exam? Examination { get; set; } 

	}
}
