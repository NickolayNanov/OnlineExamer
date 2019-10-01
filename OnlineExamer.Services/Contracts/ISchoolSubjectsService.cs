namespace OnlineExamer.Services.Contracts
{
    using System.Collections.Generic;

    using OnlineExamer.Models.SchoolSubjects;
    public interface ISchoolSubjectsService
    {
        IEnumerable<SchooolSubjectViewModel> AllSubjects();
    }
}
