using F12XA6_SOF_2023241.Models;

namespace F12XA6_SOF_2023241.Logic.Interfaces
{
    public interface ICommentLogic
    {
        Game AddToGameList(string commentId);
        void Create(Comment comment);
        Comment Create(string gameId, string content, AppUser user);
        void Delete(string id);
        IEnumerable<Comment> Read();
        Comment Read(string id);
        void Update(Comment game);
    }
}