using F12XA6_SOF_2023241.Logic.Interfaces;
using F12XA6_SOF_2023241.Models;
using F12XA6_SOF_2023241.Models.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;

namespace F12XA6_SOF_2023241.Webapp.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameLogic _gamelogic;
        private readonly UserManager<AppUser> _userManager;
        private readonly ICommentLogic _commentLogic;
        public GameController(IGameLogic gamelogic, ICommentLogic commentLogic, UserManager<AppUser> usermanager)
        {
            _gamelogic = gamelogic;
            _commentLogic = commentLogic;
            _userManager = usermanager;

        }

        // GET: GameController
        public ActionResult Index() //TODO: Studiok megjelentitese
        {
            return View(this._gamelogic.GamesByStudios());
        }

        public ActionResult ListGames()
        {
            return View(this._gamelogic.Read());
        }

        //// GET: GameController/Details/5
        //public ActionResult Details(int id)
        //{
        //    return View();
        //}

        // GET: GameController/Create
        [HttpPost]
        public ActionResult Create(Game game)
        {
            if (!ModelState.IsValid)
                return View(game);

            _gamelogic.Create(game);

            return RedirectToAction(nameof(Index));
        }
        [Authorize]
        public IActionResult CreateGame()
        {
            return View();
        }


        // GET: GameController/Delete/5
        public ActionResult Delete(string id)
        {
            _gamelogic.Delete(id);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult GameReview(string gameId, int page = 1, int pageSize = 10)
        {
            var game = _gamelogic.Read().First(g => g.Title == "Grand Theft Auto V");

            if (game == null)
            {
                return NotFound();
            }

            var comments = _commentLogic.Read().Where(c => c.GameId == game.Id).OrderBy(c => c.CreatedOn).ToList();

            var viewModel = new CommentViewModel
            {
                Game = game,
                Comments = comments,
                CommentOwner = _userManager.GetUserAsync(User).Result,
                TotalPages = _commentLogic.GetTotalPagesForGame(gameId, pageSize),
                PageSize = pageSize
            };

            return View(viewModel);
        }

        //public async Task<IActionResult> GameReview(string gameid, int page = 1, int pageSize = 2)
        //{
        //    var user = await _userManager.GetUserAsync(User);

        //    var game = _gamelogic.Read().First(g => g.Title == "Grand Theft Auto V");
        //    var comments = _commentLogic.Read().Where(c => c.GameId == game.Id).OrderBy(c => c.CreatedOn).ToList();
        //  //  var comments = _commentLogic.Read().Where(c => c.GameId == gameid).OrderBy(c => c.CreatedOn).ToList();


        //    var paginatedComments = comments.Skip((page - 1) * pageSize).Take(pageSize).ToList();

        //    var viewModel = new CommentViewModel
        //    {
        //        Game = game,
        //        Comments = paginatedComments,
        //        PageNumber = page,
        //        PageSize = pageSize,
        //        TotalComments = comments.Count(),
        //         CommentOwner = user
        //    };

        //    return View(viewModel);
        //}

        public IActionResult GetImage(string id)
        {
            var game = _gamelogic.Read(id);

            if (game.PhotoContentType.Length > 3)
                return new FileContentResult(game.PhotoData, game.PhotoContentType);

            else
                return BadRequest();

        }

        public IActionResult Error()
        {
            var exceptionHandlerPathFeature =
            HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var msg = exceptionHandlerPathFeature.Error.Message;

            return View("Error", msg);
        }

        [HttpPost]
        public async Task<IActionResult> CreateComment(string gameId, string content)
        {
            var user = await _userManager.GetUserAsync(User);

            var comment = _commentLogic.Create(gameId, content, user);
            _commentLogic.AddToGameList(comment.Id);
            var game = _gamelogic.Read(gameId);

           var viewModel = new CommentViewModel(game);
            viewModel.Comments = _commentLogic.Read().Where( c=> c.GameId == gameId).OrderBy(c=> c.CreatedOn).ToList();
            viewModel.CommentOwner = user;
            return View("GameReview", viewModel);
         
        }
        
    }
}
