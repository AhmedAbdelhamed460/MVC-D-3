using Microsoft.AspNetCore.Mvc;

namespace Day2TaskCompany.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
