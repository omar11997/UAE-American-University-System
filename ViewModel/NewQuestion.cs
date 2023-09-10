using System.ComponentModel.DataAnnotations.Schema;

namespace UAE_American_University.ViewModel
{
    public class NewQuestion
    {
        public string? QuestionBody { get; set; }
        public string? Type { get; set; }
        public int ExamId { get; set; }
    }
}
