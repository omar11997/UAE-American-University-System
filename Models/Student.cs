namespace UAE_American_University.Models
{
	public class Student
	{
        private static int nextId = 1;
        public Student()
        {
            ID = nextId;
            nextId++;
        }
        public int ID { get; set; }
		public string? Name { get; set; }

		public string? Address { get; set; }

		public int Age { get; set;}

		public string? UniversaryGrade { get; set; }

		public virtual List<StudentExam>? Exams { get; set; }
	}
}
