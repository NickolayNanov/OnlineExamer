namespace OnlineExamer.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using OnlineExamer.Data.Common.Repositories;
    using OnlineExamer.Domain;
    using OnlineExamer.Models.Exams;
    using OnlineExamer.Services.Contracts;
    public class ExamsService : IExamsService
    {
        private readonly IRepository<Exam> repository;

        public ExamsService(IRepository<Exam> repository)
        {
            this.repository = repository;
        }

        public IEnumerable<ExamViewModel> AllExams()
        {
            var allExams = this.repository
                .AllAsNoTracking(x => x != null)
                .Select(x => 
                    new ExamViewModel() 
                    { 
                        ExamType = x.ExamType.ToString() 
                    });

            return allExams;
        }

        public IEnumerable<ExamViewModel> MyExams()
        {
            throw new System.NotImplementedException();
        }
    }
}
