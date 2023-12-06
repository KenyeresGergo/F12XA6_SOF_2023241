using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using F12XA6_SOF_2023241.Logic.Interfaces;
using F12XA6_SOF_2023241.Models;
using F12XA6_SOF_2023241.Repository.Generic_Repository;
using F12XA6_SOF_2023241.Repository.Interfaces;

namespace F12XA6_SOF_2023241.Logic
{
    public class StudioLogic : IStudioLogic
    {
        private IRepository<Studios> repository;
        public StudioLogic(IRepository<Studios> repository)
        {
            this.repository = repository;
        }
        public IEnumerable<Studios> Read()
        {
            return this.repository.ReadAll();
        }
        public Studios Read(string id)
        {
            return this.repository.Read(id);
        }
        public void Update(Studios game)
        {
            repository.Update(game);
        }
        public void Delete(string id)
        {
            repository.Delete(id);
        }
        //public Game Read(Game game)
        //{
        //    return this.repository.Read(game);
        //}
        //public void Delete(Game game)
        //{
        //    repository.Delete(game);
        //}
    }
}
