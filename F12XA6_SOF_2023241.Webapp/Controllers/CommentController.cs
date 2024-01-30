using F12XA6_SOF_2023241.Logic.Interfaces;
using F12XA6_SOF_2023241.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace F12XA6_SOF_2023241.Webapp.Controllers
{
    public class CommentController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ICommentLogic _commentLogic;
        private readonly IGameLogic _gameLogic;
        public CommentController(ICommentLogic commentLogic, UserManager<AppUser> userManager, IGameLogic gameLogic)
        {
            _commentLogic = commentLogic;
            _userManager = userManager;
            _gameLogic = gameLogic;

        }



    }
}
