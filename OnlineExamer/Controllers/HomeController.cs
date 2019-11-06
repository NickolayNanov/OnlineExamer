namespace OnlineExamer.Controllers
{
    using System.Diagnostics;

    using Microsoft.AspNetCore.Mvc;

    using OnlineExamer.Models;

    public class HomeController : BaseController
    {
        public HomeController()
        {
        }

        public IActionResult Index()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Contacts()
        {
            return this.View();
        }

        [HttpGet]
        public IActionResult About()
        {
            return this.View();
        }
    }
}
