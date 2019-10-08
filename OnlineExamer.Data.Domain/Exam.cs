namespace OnlineExamer.Domain
{
    using System;
    using System.Collections.Generic;

    using OnlineExamer.Data.Common.EntityInfrastructure;
    using OnlineExamer.Data.Domain.Enums;
    using OnlineExamer.Domain.Contracts;

    public class Exam : BaseEntity<int>, IExam
    {
        public Exam()
        {
            this.ExamUsers = new HashSet<UserExam>();
            this.Questions = new HashSet<Question>();
        }

        public virtual ExamType ExamType { get; set; }

        public DateTime? StartedAt { get; private set; }

        public DateTime? FinishedAt { get; private set; }

        public virtual string ExamStartingMessage { get; }

        public int YearOfCreation { get; set; }

        public virtual ICollection<UserExam> ExamUsers { get; set; }

        public virtual ICollection<Question> Questions { get; set; }

        public void Finish()
        {
            this.FinishedAt = DateTime.UtcNow;
        }

        public void Start()
        {
            this.FinishedAt = DateTime.UtcNow;
        }

        public virtual void Sit(ApplicationUser user)
        {
            if (user is null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            user.IsSittingExam = true;
        }
    }
}
