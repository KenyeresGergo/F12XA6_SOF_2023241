using F12XA6_SOF_2023241.Logic;
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
        public CommentController(ICommentLogic commentLogic, UserManager<AppUser> userManager)
        {
            _commentLogic = commentLogic;
            _userManager = userManager;

        }


        [HttpPost]
        public async Task<IActionResult> CreateComment(string gameId, string content)
        {
            // Get the current user
            var user = await _userManager.GetUserAsync(User);

            // Create a new comment
            var comment = new Comment
            {
                Content = content,
                GameId = gameId,
                OwnerId = user.Id
            };

            // Add the comment to the database
            _commentLogic.Create(comment);           
           

            // Return a JSON result
            return Json(new { success = true, comment = comment.Content, userName = user.UserName, createdOn = comment.CreatedOn.ToString("g") });
        }


    }
}
