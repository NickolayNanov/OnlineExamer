namespace OnlineExamer.Models
{
    using System.Collections.Generic;

    using OnlineExamer.Domain;

    public class QuestionViewModel
    {
        public string Content { get; set; }

        public bool IsOpenAnswer { get; set; }

        public virtual Answer CorrectAnswer { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
