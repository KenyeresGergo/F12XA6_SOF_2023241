using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using F12XA6_SOF_2023241.Models;
using F12XA6_SOF_2023241.Models.Interfaces;
using F12XA6_SOF_2023241.Repository.DataBase;
using F12XA6_SOF_2023241.Repository.Interfaces;

namespace F12XA6_SOF_2023241.Repository.Generic_Repository
{
    public abstract class Repository<T> : IRepository<T> where T : class, IDbEntity
    {
        private readonly AppDbContext context;
        public Repository(AppDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<T> ReadAll()
        {
            var returnValues = context.Set<T>();

            return returnValues;
        }

        public T Read(string i)
        {
            return ReadAll().FirstOrDefault(g => g.Id == i);
        }

        public void Create(T entity)
        {
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(string i)
        {
            var item = Read(i);
            context.Remove(item);
            context.SaveChanges();
        }

        public abstract bool Update(T item);
    }
}
