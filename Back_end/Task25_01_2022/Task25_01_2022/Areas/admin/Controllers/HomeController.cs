using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Task25_01_2022.Data;

namespace Task25_01_2022.Areas.admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Services.ToList());
        }
    }
}
