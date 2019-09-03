namespace Examer.Services.Contracts
{
    using OnlineExamer.Data.Domain;
    using System.Collections.Generic;

    public interface ISchoolSubjectService
    {
        IEnumerable<SchoolSubject> GetAll();
    }
}
