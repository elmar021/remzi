using All_Up.DAL;
using All_Up.Models;
using All_Up.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace All_Up.Controllers
{
    public class AllController : Controller
    {
        private readonly AppDBContext _context;
        public AllController(AppDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeViewModel homewm = new HomeViewModel()
            {
                Sliders = _context.Sliders.ToList()
            };
            return View(homewm);
        }
    }
}
