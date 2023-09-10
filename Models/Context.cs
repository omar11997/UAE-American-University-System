using Microsoft.EntityFrameworkCore;

namespace UAE_American_University.Models
{
	public class Context : DbContext
	{
		public DbSet<Student> Students { get; set; }
		public DbSet<Exam> Exams { get; set; }
		public DbSet<Question> Questions { get; set; }
		public DbSet<StudentExam> StudentExams { get; set; }
        public Context(DbContextOptions options) : base(options)
        {

        }
        


	}
}
