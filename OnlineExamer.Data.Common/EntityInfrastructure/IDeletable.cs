namespace OnlineExamer.Data.Common.EntityInfrastructure
{
    using System;

    public interface IDeletable
    {
        public bool IsDeleted { get; set; }
        public DateTime? DeletedOn { get; set; }
    }
}
