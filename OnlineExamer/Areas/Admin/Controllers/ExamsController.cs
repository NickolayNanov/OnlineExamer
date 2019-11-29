namespace OnlineExamer.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using OnlineExamer.Controllers;
    using OnlineExamer.Services.Contracts;

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ExamsController : BaseController
    {
        private readonly IExamsService examsService;

        
        public ExamsController(IExamsService examsService)
        {
            this.examsService = examsService;
        }
     
        public override IActionResult Index()
        {
            var exams = this.examsService.AllExams();
            return this.View(exams);
        }
    }
}
