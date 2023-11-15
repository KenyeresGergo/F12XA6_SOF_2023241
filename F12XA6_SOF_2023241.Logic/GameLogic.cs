using F12XA6_SOF_2023241.Models;
using F12XA6_SOF_2023241.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace F12XA6_SOF_2023241.Logic
{
    public class GameLogic
    {
        AppDbContext context;
        public GameLogic(AppDbContext context)
        {
            this.context = context;
        }

        public void Create(Game game)
        {
            var gameId = context.Games.FirstOrDefault(x => x.Id == game.Id);
            if (gameId != null)
            {
                throw new ArgumentException("Game with thos name already exists!");
            }
           context.Games.Add(game);
           context.SaveChanges();
        }
        public IEnumerable<Game> Read()
        {
            return this.context.Games;
        }
        public Game? Read(Game game)
        {
            return this.context.Games.FirstOrDefault(t => t.Id == game.Id);
        }
        public Game? Read(string id)
        {
            return this.context.Games.FirstOrDefault(t => t.Id == id);
        }
        public void Update(Game game)
        {   
            var old = Read(game);
            old.Description = game.Description;
            old.Rating = game.Rating;
            old.PhotoData = game.PhotoData;
            old.StudioName = game.StudioName;
           
            old.OwnerId = game.OwnerId;
            old.Title = game.Title;
            context.SaveChanges();
        }
        public void Delete(Game game) 
        {
            var _game = Read(game);
            context.Games.Remove(_game);
            context.SaveChanges();
        } 
        public void Delete(string id) 
        {
            var _game = Read(id);
            context.Games.Remove(_game);
            context.SaveChanges();
        }

        public IEnumerable<IEnumerable<Game>> GamesByStudios()
        {
            var res = from game in context.Games
                      group game by game.StudioName
                      into g orderby g.Key
                      select g;
            return res;
                      
        }
    }
}
