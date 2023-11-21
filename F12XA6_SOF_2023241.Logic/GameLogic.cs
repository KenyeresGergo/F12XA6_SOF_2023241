using F12XA6_SOF_2023241.Logic.Interfaces;
using F12XA6_SOF_2023241.Models;
using F12XA6_SOF_2023241.Repository.DataBase;
using F12XA6_SOF_2023241.Repository.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace F12XA6_SOF_2023241.Logic
{
    public class GameLogic : IGameLogic
    {
        private readonly IRepository<Game> repository;

        public GameLogic(IRepository<Game> repository)
        {
            this.repository = repository;
        }
        public void Create(Game game)
        {
            if (game == null)
            {
                throw new InvalidDataException("The game Cannot be null!");
            }
            else if (game.Title == "")
            {
                throw new Exception("The game title cannot be an empty string!");
            }
            else if (game.Title == null || game.Owner == null || game.OwnerId == null || game.Rating == null || game.Studios == null || game.StudiosId == null)
            {
                throw new InvalidDataException();
            }
            this.repository.Create(game);
        }
        public IEnumerable<Game> Read()
        {
            return this.repository.ReadAll();
        }
        //public Game Read(Game game)
        //{
        //    return this.repository.Read(game);
        //}
        public Game Read(string id)
        {
            return this.repository.Read(id);
        }
        public void Update(Game game)
        {
            repository.Update(game);
        }
        //public void Delete(Game game)
        //{
        //    repository.Delete(game);
        //}
        public void Delete(string id)
        {
            repository.Delete(id);
        }
        public IEnumerable<Game> GamesByStudioId(string studioid)
        {
            return repository.ReadAll().Where(g=> g.StudiosId == studioid).ToList();

        }
     
        public IEnumerable<Game> MyGames(AppUser user) //adott felhsználóhoz tartozó játékok
        {
           
            return user.GamesOwned;
        }

        public IEnumerable<IEnumerable<Game>> GamesByStudios()
        {
            var res = from game in repository.ReadAll()
                      group game by game.StudiosId
                      into g
                      orderby g.Key
                      select g;
            return res;

        }
    }
}
