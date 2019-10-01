namespace OnlineExamer.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using OnlineExamer.Services.Contracts;

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
    }
}
