using DotNetBookstore.Data;
using Microsoft.AspNetCore.Mvc;

namespace DotNetBookstore.Controllers
{
    public class ShopController : Controller
    {
        // class level DbContext connection object
        private readonly ApplicationDbContext _context;

        // constructor that accept a DbContext instance
        public ShopController (ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            // query the list of categories in a-z order for display
            var categories = _context.Categories.OrderBy(c => c.Name).ToList();
            return View(categories);
        }
    }
}
