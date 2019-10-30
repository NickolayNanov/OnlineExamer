namespace OnlineExamer.Models.Exams
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class ExamQuestions
    {
        public string ExamType { get; set; }

        public int YearOfCreation { get; set; }


        public virtual string StartingMessage { get; set; }

        [Required]
        public IList<QuestionViewModel> Questions { get; set; }

        [Required]
        public IList<AnswerViewModel> Answers { get; set; }
    }
}
