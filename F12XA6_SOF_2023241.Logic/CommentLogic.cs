using F12XA6_SOF_2023241.Logic.Interfaces;
using F12XA6_SOF_2023241.Models;
using F12XA6_SOF_2023241.Repository.Interfaces;
using F12XA6_SOF_2023241.Repository.Model_Repositories;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F12XA6_SOF_2023241.Logic
{
    public class CommentLogic : ICommentLogic
    {
        private ICommentRepository repository;
        private IRepository<Game> gamerepo;
        private readonly UserManager<AppUser> _userManager;

        public CommentLogic(ICommentRepository repository, IRepository<Game> gamerepo, UserManager<AppUser> userManager)
        {
            this.repository = repository;
            this.gamerepo = gamerepo;
            _userManager = userManager;
        }

        
        public Comment Create(string gameId, string content, AppUser user)
        {

            var comment = new Comment
            {
                Content = content,
                GameId = gameId,
                OwnerId = user.Id,
                //Owner = user,
                CreatedOn = DateTime.Now,

            };
            this.repository.Create(comment);
            return comment;
        }
        public void Create(Comment comment)
        {
            this.repository.Create(comment);

        }
        public Comment Read(string id)
        {
            return this.repository.Read(id);
        }
        public IEnumerable<Comment> Read()
        {
            return this.repository.ReadAll();
        }
        public void Update(Comment game)
        {
            repository.Update(game);
        }
        public void Delete(string id)
        {
            repository.Delete(id);
        }

        public Game AddToGameList(string commentId)
        {
            Comment comment = this.Read(commentId);
            Game game = gamerepo.Read(comment.GameId);
            game.Comments.Add(comment);
            return game;
        }

        public IEnumerable<Comment> GetCommentsForGame(string gameId, int page, int pageSize)
        {
            return repository.GetCommentsForGame(gameId, page, pageSize);
        }
        public int GetTotalPagesForGame(string gameId, int pageSize)
        {
            return repository.GetTotalPagesForGame(gameId, pageSize);
        }



    }
}
