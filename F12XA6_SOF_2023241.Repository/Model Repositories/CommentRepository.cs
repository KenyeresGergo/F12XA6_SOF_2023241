using F12XA6_SOF_2023241.Models;
using F12XA6_SOF_2023241.Repository.DataBase;
using F12XA6_SOF_2023241.Repository.Generic_Repository;
using F12XA6_SOF_2023241.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F12XA6_SOF_2023241.Repository.Model_Repositories
{
    public class CommentRepository : Repository<Comment>, IRepository<Comment>
    {
        private readonly AppDbContext context;
        public CommentRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }

        public void Create(Comment comment)
        {
            var commId = context.Comments.FirstOrDefault(x => x.Id == comment.Id);

            if (commId != null)
                throw new ArgumentException("Game with thos name already exists!");

            context.Comments.Add(comment);
            context.SaveChanges();
        }
        public IEnumerable<Comment> Read()
        {
            return this.context.Comments;
        }
        public Comment Read(Comment game)
        {
            return this.context.Comments.FirstOrDefault(t => t.Id == game.Id);
        }
        public Comment Read(string id)
        {
            return this.context.Comments.FirstOrDefault(t => t.Id == id);
        }
        public override bool Update(Comment item)
        {
            //var sourceItem = Read(item.Id);

            //if (sourceItem == null)
            //    return false;

            //sourceItem.CopyFrom(item);
            //context.SaveChanges();

            return true;
        }
        public void Delete(Comment game)
        {
            var _game = Read(game);
            context.Comments.Remove(_game);
            context.SaveChanges();
        }
        public void Delete(string id)
        {
            var _game = Read(id);
            context.Comments.Remove(_game);
            context.SaveChanges();
        }

    }
}
