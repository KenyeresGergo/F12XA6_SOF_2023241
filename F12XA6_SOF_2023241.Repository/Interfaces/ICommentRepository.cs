using F12XA6_SOF_2023241.Models;

namespace F12XA6_SOF_2023241.Repository.Interfaces
{
    public interface ICommentRepository : IRepository<Comment>
    {
        void Create(Comment comment);
        void Delete(Comment game);
        void Delete(string id);
        IEnumerable<Comment> GetCommentsForGame(string gameId, int page, int pageSize);
        int GetTotalPagesForGame(string gameId, int pageSize);
        IEnumerable<Comment> Read();
        Comment Read(Comment game);
        Comment Read(string id);
        bool Update(Comment item);
    }
}