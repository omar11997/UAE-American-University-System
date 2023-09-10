using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace UAE_American_University.Models
{
	public class Exam
	{
        private static int nextId = 1;
        public Exam()
        {
            ID = nextId;
            nextId++;
        }
        public int ID { get; set; }
		public string? Name { get; set; }

		public int TotalDegree { get; set; }
        public string? CourseName { get; set; }
        public int Year { get; set; }
		public List<Question>? Questions { get; set; } = new List<Question>();

		public virtual List<StudentExam>? StudentExams { get; set; }
	}
}
