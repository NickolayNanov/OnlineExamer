namespace OnlineExamer.Domain.Contracts
{
    using System;
    using System.Collections.Generic;

    public interface IExam
    {
        string ExamStartingMessage { get; }

        DateTime? StartedAt { get; }

        DateTime? FinishedAt { get; }

        ICollection<UserExam> ExamUsers { get; set; }

        void Sit(ExamerUser user);

        void Start();

        void Finish();
    }
}
