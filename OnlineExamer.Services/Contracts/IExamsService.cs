namespace OnlineExamer.Services.Contracts
{
    using System.Collections.Generic;

    using OnlineExamer.Models.Exams;
    public interface IExamsService
    {
        IEnumerable<ExamViewModel> AllExams();

        IEnumerable<ExamViewModel> MyExams();

        IEnumerable<ExamViewModel> GetExamsByType(string examType);

        FinalExamQuestions GetExamByYear(int year);
    }
}
