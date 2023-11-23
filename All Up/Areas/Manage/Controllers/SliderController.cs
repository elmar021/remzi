using All_Up.DAL;
using All_Up.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace All_Up.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class SliderController : Controller
    {
        private readonly AppDBContext _context;
        public SliderController(AppDBContext context)
        {
            _context=context;
        }
        public IActionResult Index()
        {
            HomeViewModel homewm = new HomeViewModel() 
            {
                Sliders = _context.Sliders.ToList()
            };
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
    }
}
