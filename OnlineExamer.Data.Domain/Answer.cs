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
            this.Content = content;
        }

        public string Content { get; set; }

        public int QuestionId { get; set; }
        public virtual Question Question { get; set; }
    }
}
