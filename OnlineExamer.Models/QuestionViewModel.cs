namespace OnlineExamer.Models
{
    using System.Collections.Generic;

    using OnlineExamer.Domain;
    using OnlineExamer.Models.Exams;

    public class QuestionViewModel
    {
        public string Content { get; set; }

        public bool IsOpenAnswer { get; set; }

        public int CorrectAnswer { get; set; }

        public virtual IList<AnswerViewModel> Answers { get; set; }
    }
}
