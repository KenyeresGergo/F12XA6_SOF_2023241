using F12XA6_SOF_2023241.Models;

namespace F12XA6_SOF_2023241.Logic.Interfaces
{
    public interface IGameLogic
    {
        void Create(Game game);

        void Delete(string id);

        IEnumerable<Game> Read();
        Game Read(string id);

        void Update(Game game);

        IEnumerable<Game> GamesByStudioId(string studioid);
        IEnumerable<IEnumerable<Game>> GamesByStudios();
        IEnumerable<Game> MyGames(AppUser user);
    }
}