namespace OnlineExamer.Domain
{
    using OnlineExamer.Data.Common.Models;

    public class Answer : BaseModel<int>
    {
        public Answer()
        {

        }

        public string Contnent { get; set; }

        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}
