namespace OnlineExamer.Domain
{
    using OnlineExamer.Data.Common.Models;
    using OnlineExamer.Domain.Contracts;
    using System;
    using System.Collections.Generic;

    public class Exam : BaseModel<int>, IExam
    {
        public Exam()
        {
            this.ExamUsers = new HashSet<UserExam>();
        }

        public bool HasBeenStarted { get; set; }

        public DateTime? StartedAt { get; private set; }

        public DateTime? FinishedAt { get; private set; }

        public virtual string ExamStartingMessage { get; }

        public ICollection<UserExam> ExamUsers { get; set; }

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

        public virtual void Sit(ExamerUser user)
        {
            if (user is null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            user.IsSittingExam = true;
        }
    }
}
