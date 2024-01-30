using F12XA6_SOF_2023241.Logic;
using F12XA6_SOF_2023241.Logic.Interfaces;
using F12XA6_SOF_2023241.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
       

        public IActionResult GameReview(string gameid)
        {
            return View(_gamelogic.Read().First(g=>g.Title == "Grand Theft Auto V"));
        }

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

            // Return a JSON result
            //return Json(new { success = true, comment = comment.Content, userName = user.UserName, createdOn = comment.CreatedOn.ToString("g") });
            //return PartialView("_CommentsPartial", _commentLogic.AddToGameList(comment.Id));
            return View("GameReview",game );
          //return RedirectToAction(nameof(Asd));
        }
        //public IActionResult Asd(in string gameId)
        //{
        //    var game = _gamelogic.Read(gameId);
        //    return View("GameReview", game);
        //}

    }
}
