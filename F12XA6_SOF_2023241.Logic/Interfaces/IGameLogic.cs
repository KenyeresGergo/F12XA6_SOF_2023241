using F12XA6_SOF_2023241.Models;

namespace F12XA6_SOF_2023241.Logic.Interfaces
{
    public interface IGameLogic
    {
        void AddToCommentList(Comment comment, in Game game);
        void Create(Game game);
        void Delete(string id);
        IEnumerable<Game> GamesByStudioId(string studioid);
        IEnumerable<IEnumerable<Game>> GamesByStudios();
        IEnumerable<Game> MyGames(AppUser user);
        IEnumerable<Game> Read();
        Game Read(string id);
        void Update(Game game);
    }
}