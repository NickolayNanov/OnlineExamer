using OnlineExamer.Models.Exams;
using System.Collections;
using System.Collections.Generic;

namespace OnlineExamer.Services.Contracts
{
    public interface IExamsService
    {
        IEnumerable<ExamViewModel> AllExams();

        IEnumerable<ExamViewModel> MyExams();
    }
}
