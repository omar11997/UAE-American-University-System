using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace UAE_American_University.Models
{
	public class Question
	{

        private static int nextId = 1;
		public Question() {
			ID = nextId;
			nextId++;
		}
		
        public int ID { get; set; }

		public string? QuestionBody { get; set; }
		public int QuetionScore { get; set; }
		public string? OptionalAnswer { get; set; }
        public string? RightAnswer { get; set; }
        public string? Type { get; set; }
        [ForeignKey("Exam")]
		public int ExamId { get; set; }

		public virtual Exam? Exam { get; set; }

	}
}
