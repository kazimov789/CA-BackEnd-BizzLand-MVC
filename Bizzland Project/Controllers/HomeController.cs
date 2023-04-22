using Bizzland_Project.DataAccess;
using Microsoft.AspNetCore.Mvc;

namespace Bizzland_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _context;
        public HomeController(DataContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context);
        }
    }
}
