using F12XA6_SOF_2023241.Models;
using F12XA6_SOF_2023241.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq; // Make sure to add this

namespace F12XA6_SOF_2023241.Webapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index(int page = 1)
        {
            int pageSize = 6;

            // Assuming Studios is a DbSet in your AppDbContext
            //var studios = _context.Studios
            //    .Skip((page - 1) * pageSize)
            //    .Take(pageSize)
            //    .ToList();

            return View(/*studios*/);
        }

        public IActionResult Games()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}