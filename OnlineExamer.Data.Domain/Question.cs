namespace OnlineExamer.Domain
{
    using System.Collections.Generic;

    using OnlineExamer.Data.Common.EntityInfrastructure;

    public class Question : BaseEntity<int>
    {
        public Question()
        {
            this.Answers = new HashSet<Answer>();
        }

        public string Content { get; set; }
        
        public int ExamId { get; set; }
        public virtual Exam Exam { get; set; }

        public bool IsOpenAnswer { get; set; }

        public int CorrectAnswer { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
