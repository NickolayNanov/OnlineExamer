namespace OnlineExamer.Services
{
    using System.Collections.Generic;
    using System.Linq;

    using OnlineExamer.Data.Common.Repositories;
    using OnlineExamer.Domain;
    using OnlineExamer.Models.SchoolSubjects;
    using OnlineExamer.Services.Contracts;

    public class SchoolSubjectsService : ISchoolSubjectsService
    {
        private readonly IRepository<SchoolSubject> subjectsRepository;

        public SchoolSubjectsService(IRepository<SchoolSubject> subjectsRepository)
        {
            this.subjectsRepository = subjectsRepository;
        }

        public IEnumerable<SchooolSubjectViewModel> AllSubjects()
        {
            var subjects = this.subjectsRepository
                .AllAsNoTracking(x => !string.IsNullOrWhiteSpace(x.Name))
                .Select(sub => new SchooolSubjectViewModel() { Name = sub.Name });

            return subjects;
        }
    }
}
