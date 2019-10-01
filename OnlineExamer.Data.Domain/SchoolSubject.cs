namespace OnlineExamer.Domain
{
    using OnlineExamer.Data.Common.EntityInfrastructure;

    public class SchoolSubject : BaseEntity<int>
    {
        public SchoolSubject()
        {
            
        }
        
        public string Name { get; set; }
    }
}
