namespace OnlineExamer.Models.Exams
{
    using System.Collections.Generic;

    public class ExamQuestions
    {
        public string ExamType { get; set; }

        public int YearOfCreation { get; set; }


        public virtual string StartingMessage { get; set; }

        public IEnumerable<QuestionViewModel> Questions { get; set; }
    }
}
