using F12XA6_SOF_2023241.Models.Interfaces;

namespace F12XA6_SOF_2023241.Repository.Interfaces
{
    public interface IRepository<T> where T : class, IDbEntity
    {
        void Create(T entity);
        void Delete(string i);
        T Read(string i);
        IEnumerable<T> ReadAll();
        bool Update(T item);
    }
}