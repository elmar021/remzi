using Microsoft.AspNetCore.Mvc;

namespace All_Up.Areas.Manage.Controllers
{
    public class DashBoardController : Controller
    {
        [Area("Manage")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
