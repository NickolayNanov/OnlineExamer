namespace Examer.Services.Contracts
{
    using Examer.Domain;
    using System.Collections.Generic;

    public interface ISchoolSubjectService
    {
        IEnumerable<SchoolSubject> GetAll();
    }
}
