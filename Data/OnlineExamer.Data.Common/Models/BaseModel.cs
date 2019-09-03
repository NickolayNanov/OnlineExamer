namespace OnlineExamer.Data.Common.Models
{
    using System;

    public class BaseModel<TKey> : IDeleteable, IEditable
    {
        public BaseModel()
        {
            this.CreatedOn = DateTime.UtcNow;
            this.IsDeleted = false;
        }

        public TKey Id { get; set; }

        public DateTime? CreatedOn { get; set; }

        public DateTime? EdditedOn { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool IsDeleted { get; set; }
    }
}
