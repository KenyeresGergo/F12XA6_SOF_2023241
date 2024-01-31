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
        private readonly IStudioLogic _studioLogic;
        public GameController(IGameLogic gamelogic, ICommentLogic commentLogic, UserManager<AppUser> usermanager, IStudioLogic studioLogic)
        {
            _gamelogic = gamelogic;
            _commentLogic = commentLogic;
            _userManager = usermanager;
            _studioLogic = studioLogic;
        }

        // GET: GameController
        public ActionResult Index()
        {

            var model = new HomePageViewModel(this.GetStudios(), 1, 6);
            return View("~/Views/Home/Index.cshtml", model);
        }

        public ActionResult ListGames()
        {
            return View(this._gamelogic.Read());
        }


        // GET: GameController/Create
        //[HttpPost]
        //public ActionResult Create(Game game)
        //{
        //    if (!ModelState.IsValid)
        //        return View(game);

        //    _gamelogic.Create(game);

        //    return RedirectToAction(nameof(Index));
        //}
        //[Authorize]
        //public IActionResult CreateGame()
        //{
        //    return View();
        //}


        // GET: GameController/Delete/5
        public ActionResult Delete(string id)
        {
            _gamelogic.Delete(id);

            return RedirectToAction(nameof(Index));
        }
        [Authorize]
        public IActionResult GameReview(string gameId, int page = 1, int pageSize = 10)
        {
            var game = _gamelogic.Read().First(g => g.Id == gameId);

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
        [Authorize]
        public async Task<IActionResult> CreateComment(string gameId, string content)
        {
            var user = await _userManager.GetUserAsync(User);

            var comment = _commentLogic.Create(gameId, content, user);
            _commentLogic.AddToGameList(comment.Id);
            var game = _gamelogic.Read(gameId);

            var viewModel = new CommentViewModel(game);
            viewModel.Comments = _commentLogic.Read().Where(c => c.GameId == gameId).OrderBy(c => c.CreatedOn).ToList();
            viewModel.CommentOwner = user;
            return View("GameReview", viewModel);

        }

        public List<Studios> GetStudios()
        {
            return _studioLogic.Read().ToList();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create(Game game)
        {
           

          

            if (game.PhotoFile != null && game.PhotoFile.Length > 0)
            {
                // Process the uploaded image and set properties in the game model
                game.PhotoContentType = game.PhotoFile.ContentType;

                using (var memoryStream = new MemoryStream())
                {
                    await game.PhotoFile.CopyToAsync(memoryStream);
                    game.PhotoData = memoryStream.ToArray();
                }
            }
            var user = await _userManager.GetUserAsync(User);
            //game.Owner = user;
            game.OwnerId = user.Id.ToString();
          //  game.Studios = _studioLogic.Read(game.StudiosId);
            //if (!ModelState.IsValid)
            //{
            //    ViewBag.Studios = GetStudios();
            //    return View("CreateGame", game);
            //}

            _gamelogic.Create(game);

            return RedirectToAction(nameof(Index));
        }
        [Authorize]
        public IActionResult CreateGame()
        {
            ViewBag.Studios = GetStudios();
            return View();
        }


    }
}
