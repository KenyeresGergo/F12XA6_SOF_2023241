using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F12XA6_SOF_2023241.Models;
using F12XA6_SOF_2023241.Repository.Interfaces;
using F12XA6_SOF_2023241.Repository.Generic_Repository;
using F12XA6_SOF_2023241.Repository.DataBase;

namespace F12XA6_SOF_2023241.Repository.Model_Repositories
{
    public class GameRepository : Repository<Game>, IRepository<Game>
    {
        private readonly AppDbContext context;
        public GameRepository(AppDbContext context) : base(context)
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
        public Game Read(Game game)
        {
            return this.context.Games.FirstOrDefault(t => t.Id == game.Id);
        }
        public Game Read(string id)
        {
            return this.context.Games.FirstOrDefault(t => t.Id == id);
        }
        public override bool Update(Game item)
        {
            var sourceItem = Read(item.Id);
            if (sourceItem == null)
            {
                return false;
            }

            sourceItem.CopyFrom(item);
            context.SaveChanges();
            return true;
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
    }
}
