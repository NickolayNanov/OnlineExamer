namespace OnlineExamer.Domain
{
    public class OrdinaryExam : Exam
    {
        public OrdinaryExam()
            : base()
        {

        }

        public override string ExamStartingMessage => "Нормален тест";     
    }
}
