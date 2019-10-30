namespace OnlineExamer.Domain
{
    public class UserExam
    {
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }
    
        public int ExamId { get; set; }

        public virtual Exam Exam { get; set; }

        public double Grade { get; set; }

        public bool HasBeenStarted { get; set; }

        public int Points { get; set; }
    }
}
