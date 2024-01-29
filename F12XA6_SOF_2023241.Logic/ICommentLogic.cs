using F12XA6_SOF_2023241.Models;

namespace F12XA6_SOF_2023241.Logic
{
    public interface ICommentLogic
    {
        void Create(Comment comment);
        void Delete(string id);
        IEnumerable<Comment> Read();
        Comment Read(string id);
        void Update(Comment game);
    }
}