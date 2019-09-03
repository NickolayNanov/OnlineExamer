namespace OnlineExamer.Domain
{
    using OnlineExamer.Data.Common.Models;    

    public class SchoolSubject : BaseModel<int>
    {
        public SchoolSubject()
        {
            
        }

        public string Name { get; set; }
    }
}
