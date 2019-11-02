namespace OnlineExamer.Services.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using OnlineExamer.Models.Exams;

    public interface IUserExamsService
    {
        Task<IEnumerable<MyExamViewModel>> GetExamsForUser(string user);
    }
}
