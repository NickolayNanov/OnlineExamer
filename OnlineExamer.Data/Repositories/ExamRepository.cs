namespace OnlineExamer.Data.Repositories
{
    using OnlineExamer.Domain;
    using OnlineExamer.Domain.Contracts;

    using System.Linq;

    public class ExamRepository : EfRepository<Exam>, IExamRepository
    {
        public ExamRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IExam GetExamByYear(int year)
        {
            return this.Data.FirstOrDefault(exam => exam.YearOfCreation == year);
        }
    }
}
