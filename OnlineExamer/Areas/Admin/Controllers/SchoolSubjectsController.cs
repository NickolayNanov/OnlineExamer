namespace OnlineExamer.Areas.Admin.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using OnlineExamer.Controllers;

    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SchoolSubjectsController : BaseController
    {
        
    }
}
