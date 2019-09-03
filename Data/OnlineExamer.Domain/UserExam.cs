namespace OnlineExamer.Domain
{
    public class UserExam
    {
        public string UserId { get; set; }

        public virtual ExamerUser User { get; set; }
    
        public int ExamId { get; set; }

        public virtual Exam Exam { get; set; }

        public double Grade { get; set; }
    }
}
