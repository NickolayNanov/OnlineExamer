namespace OnlineExamer.Controllers
{
    using Microsoft.AspNetCore.Mvc;


    public class BaseController : Controller
    {
        public virtual IActionResult Index()
        {
            return this.View();
        }
    }
}
