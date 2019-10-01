namespace OnlineExamer.Domain
{
    using OnlineExamer.Data.Common.EntityInfrastructure;

    public class Answer : BaseEntity<int>
    {
        public Answer()
        {

        }
        public Answer(string content)
        {
            this.Contnent = content;
        }

        public string Contnent { get; set; }

        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}
