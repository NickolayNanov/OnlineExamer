namespace OnlineExamer.Data.Common.EntityInfrastructure
{
    using System;

    public class BaseEntity<TKey> : IDeletable
    {
        public BaseEntity()
        {
            this.DeletedOn = DateTime.UtcNow;
        }

        public TKey Id { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}
