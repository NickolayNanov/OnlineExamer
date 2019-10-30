namespace OnlineExamer.Data
{
    using OnlineExamer.Data.Common.Repositories;
    using OnlineExamer.Domain;
    using OnlineExamer.Domain.Contracts;

    public interface IExamRepository : IRepository<Exam>
    {
        IExam GetExamByYear(int year);
    }
}
