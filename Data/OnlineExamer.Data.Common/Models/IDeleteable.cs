namespace OnlineExamer.Data.Common.Models
{
    using System;
    
    public interface IDeleteable
    {
        DateTime? DeletedOn { get; }

        bool IsDeleted { get; }
    }
}
