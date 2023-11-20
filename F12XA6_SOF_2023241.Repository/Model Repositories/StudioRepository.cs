using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F12XA6_SOF_2023241.Models;
using F12XA6_SOF_2023241.Repository.Interfaces;
using F12XA6_SOF_2023241.Repository.Generic_Repository;
using F12XA6_SOF_2023241.Repository.DataBase;
using F12XA6_SOF_2023241.Models.Interfaces;

namespace F12XA6_SOF_2023241.Repository.Model_Repositories
{
    public class StudioRepository : Repository<Studios>, IRepository<Studios>
    {
        private readonly AppDbContext context;
        public StudioRepository(AppDbContext context) : base(context)
        {
            this.context = context;
        }

        public void Create(Studios studio)
        {
            var studioId = context.Studios.FirstOrDefault(x => x.Id == studio.Id);
            if (studioId != null)
            {
                throw new ArgumentException("Game with thos name already exists!");
            }
            context.Studios.Add(studio);
            context.SaveChanges();
        }
        public IEnumerable<Studios> Read()
        {
            return this.context.Studios;
        }
        public Studios Read(Studios studio)
        {
            return this.context.Studios.FirstOrDefault(t => t.Id == studio.Id);
        }
        public Studios Read(string id)
        {
            return this.context.Studios.FirstOrDefault(t => t.Id == id);
        }
        public override bool Update(Studios item)
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
        public void Delete(Studios game)
        {
            var _studio = Read(game);
            context.Studios.Remove(_studio);
            context.SaveChanges();
        }
        public void Delete(string id)
        {
            var _studio = Read(id);
            context.Studios.Remove(_studio);
            context.SaveChanges();
        }
    }
}
