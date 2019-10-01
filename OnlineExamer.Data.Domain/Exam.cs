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

        public bool HasBeenStarted { get; set; }

        public DateTime? StartedAt { get; private set; }

        public DateTime? FinishedAt { get; private set; }

        public virtual string ExamStartingMessage { get; }

        public virtual ICollection<UserExam> ExamUsers { get; set; }

        public virtual ICollection<Question> Questions { get; set; }

        public void Finish()
        {
            if (this.HasBeenStarted)
            {
                this.FinishedAt = DateTime.UtcNow;
            }
            else
            {
                throw new InvalidOperationException("You need to start an exam first");
            }
        } 

        public void Start()
        {
            this.HasBeenStarted = true;
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
