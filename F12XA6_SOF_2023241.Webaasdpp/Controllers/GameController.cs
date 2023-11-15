using F12XA6_SOF_2023241.Logic;
using F12XA6_SOF_2023241.Models;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace F12XA6_SOF_2023241.Webapp.Controllers
{
    public class GameController : Controller
    {
        GameLogic _logic;
        public GameController(GameLogic logic)
        { 
            this._logic = logic;

        }

        // GET: GameController
        public ActionResult Index() //TODO: Studiok megjelentitese
        {
            return View(this._logic.GamesByStudios());
        }
        public ActionResult ListGames()
        {
            return View(this._logic.Read());
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
            _logic.Create(game);
            return RedirectToAction(nameof(Index));
        }


        // GET: GameController/Delete/5
        public ActionResult Delete(string id)
        {
            _logic.Delete(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult GetImage(string id)
        {
            var game = _logic.Read(id);
            if (game.ContentType.Length > 3)
            {
                return new FileContentResult(game.PhotoData, game.ContentType);
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
