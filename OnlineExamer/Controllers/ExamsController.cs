namespace OnlineExamer.Controllers
{

    using System.Threading.Tasks;

    using Microsoft.AspNetCore.Mvc;

    using OnlineExamer.Models.Exams;
    using OnlineExamer.Services.Contracts;

    public class ExamsController : BaseController
    {
        private readonly IExamsService examsService;
        private readonly IUserExamsService userExamsService;

        public ExamsController(IExamsService examsService,
                                IUserExamsService userExamsService)
        {
            this.examsService = examsService;
            this.userExamsService = userExamsService;
        }

        public async Task<IActionResult> GetSatExams()
        {
            var exams = await this.userExamsService.GetSatExamsByUser(this.User.Identity.Name);
            return this.View(exams);
        }

        public async Task<IActionResult> MyExamTypes()
        {
            var exams = await this.userExamsService.GetExamTypesForUser(this.User.Identity.Name);
            return this.View(exams);
        }

        [HttpGet]
        public async Task<IActionResult> MyExams()
        {
            var exams = await this.userExamsService.GetExamsForUser(this.User.Identity.Name);
            return this.View(exams);
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
