using F12XA6_SOF_2023241.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Data;
using System.Diagnostics;
using System.Linq;
using F12XA6_SOF_2023241.Repository.DataBase;
using F12XA6_SOF_2023241.Logic.Interfaces;

namespace F12XA6_SOF_2023241.Webapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGameLogic _gamelogic;
        private readonly IStudioLogic _studiologic;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailSender _emailSender;

        public HomeController(ILogger<HomeController> logger, IGameLogic gamelogic, IStudioLogic studiologic, UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager, IEmailSender emailSender)
        {
            _logger = logger;
            _gamelogic = gamelogic;
            _studiologic = studiologic;
            _userManager = userManager;
            _roleManager = roleManager;
            _emailSender = emailSender;
        }

        public IActionResult Index(int page = 1)
        {
            var user = new AppUser();
            HttpContext.Session.SetString("appuser",JsonConvert.SerializeObject(user));

            int pageSize = 6;

            var totalStudios = _studiologic.Read().Count();
            var totalPages = (int)Math.Ceiling((double)totalStudios / pageSize);

            var studios = _studiologic.Read()
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToList();

            var viewModel = new HomePageViewModel(studios, page, totalPages);

            return View(viewModel);
        }
        [Authorize]
        public async Task<IActionResult> MyGames()
        {
            return View(_gamelogic.MyGames(await _userManager.GetUserAsync(this.User)));
         
        }

        public async Task<IActionResult> DelegateAdmin()
        {
            var principal = this.User;

            var user = await _userManager.GetUserAsync(principal);

            var role = new IdentityRole(){ Name = "Admin"};

            if (!await _roleManager.RoleExistsAsync("Admin"))
                await _roleManager.CreateAsync(role);

            await _userManager.AddToRoleAsync(user, "Admin");

            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RemoveAdmin(string uid)
        {
            var user = _userManager.Users.FirstOrDefault(t => t.Id == uid);
            await _userManager.RemoveFromRoleAsync(user, "Admin");

            return RedirectToAction(nameof(Users));
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> GrantAdmin(string uid)
        {
            var user = _userManager.Users.FirstOrDefault(t => t.Id == uid);
            await _userManager.AddToRoleAsync(user, "Admin");

            return RedirectToAction(nameof(Users));
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Users()
        {
            return View(_userManager.Users);
        }
        [Authorize]
        public IActionResult CreateGame()
        {
            return View();
        }

        [Authorize]
        public IActionResult Games(string studioId = null)
        {
            if (studioId == null)
            {
                var games = _gamelogic.Read();

                return View(games);
            }
            else
            {
                var games = _gamelogic.GamesByStudioId(studioId);

                return View(games);
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}