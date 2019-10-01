namespace OnlineExamer.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    using OnlineExamer.Services.Contracts;

    public class SchoolSubjectsController : Controller
    {
        private readonly ISchoolSubjectsService subjectsService;

        public SchoolSubjectsController(ISchoolSubjectsService subjectsService)
        {
            this.subjectsService = subjectsService;
        }

        public IActionResult SubjectsAll()
        {
            var subjects = this.subjectsService.AllSubjects();
            return View(subjects);
        }
    }
}