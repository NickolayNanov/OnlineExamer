namespace OnlineExamer.Domain.Contracts
{
    using OnlineExamer.Data.Domain.Enums;
    using System;
    using System.Collections.Generic;

    public interface IExam
    {
        ExamType ExamType { get; set; }

        string ExamStartingMessage { get; }

        DateTime? StartedAt { get; }

        DateTime? FinishedAt { get; }

        void Sit(ApplicationUser user);

        void Start();

        void Finish();

        ICollection<UserExam> ExamUsers { get; set; }
    }
}
