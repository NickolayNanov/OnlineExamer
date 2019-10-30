namespace OnlineExamer.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using OnlineExamer.Models.Exams;
    using OnlineExamer.Services.Contracts;
    using System.Threading.Tasks;

    public class ExamsController : BaseController
    {
        private readonly IExamsService examsService;

        public ExamsController(IExamsService examsService)
        {
            this.examsService = examsService;
        }

        [HttpGet]
        public IActionResult MyExams()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult AllExams()
        {
            var exams = this.examsService.AllExams();
            return this.View(exams);
        }

        [HttpGet]
        public IActionResult LoadingExam(string examType)
        {
            var exams = this.examsService.GetExamsByType(examType);
            return this.View(exams);
        }

        [HttpGet]
        public IActionResult SolveExam(int year)
        {
            var exam = this.examsService.GetExamByYear(year);
            return this.View(exam);
        }

        [HttpPost]
        public async Task<IActionResult> SolveExamPost(ExamQuestions exam)
        {
            int points = await this.examsService.SolveExam(exam, this.User.Identity.Name);
            return this.View("ExamResult", points);
        }
    }
}
