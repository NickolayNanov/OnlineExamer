namespace OnlineExamer.Domain
{
    using OnlineExamer.Data.Common.Models;
    using System.Collections.Generic;

    public class Question : BaseModel<int>
    {
        public Question()
        {

        }

        public string Content { get; set; }

        public virtual ICollection<Answer> Answers { get; set; }
    }
}
