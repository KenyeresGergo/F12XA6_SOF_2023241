using F12XA6_SOF_2023241.Logic;
using F12XA6_SOF_2023241.Logic.Interfaces;
using F12XA6_SOF_2023241.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace F12XA6_SOF_2023241.Webapp.Controllers
{
    public class GameController : Controller
    {
        private readonly IGameLogic _gamelogic;
        public GameController(IGameLogic gamelogic)
        {
            _gamelogic = gamelogic;

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
            {
                return View(game);
            }
            _gamelogic.Create(game);
            return RedirectToAction(nameof(Index));
        }


        // GET: GameController/Delete/5
        public ActionResult Delete(string id)
        {
            _gamelogic.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult GetImage(string id)
        {
            var game = _gamelogic.Read(id);
            if (game.PhotoContentType.Length > 3)
            {
                return new FileContentResult(game.PhotoData, game.PhotoContentType);
            }
            else
            {
                return BadRequest();
            }

        }

        public IActionResult Error()
        {
            var exceptionHandlerPathFeature =
            HttpContext.Features.Get<IExceptionHandlerPathFeature>();
            var msg = exceptionHandlerPathFeature.Error.Message;
            return View("Error", msg);
        }
    }
}
