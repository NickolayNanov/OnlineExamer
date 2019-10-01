namespace OnlineExamer.Domain
{
    public class FinalExam : Exam
    {
        public FinalExam()
            : base()
        {
        }

        public override string ExamStartingMessage => "Начало на пробна матура";
    }
}
