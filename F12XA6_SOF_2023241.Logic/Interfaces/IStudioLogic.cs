using F12XA6_SOF_2023241.Models;

namespace F12XA6_SOF_2023241.Logic.Interfaces
{
    public interface IStudioLogic
    {
        void Delete(string id);
        IEnumerable<Studios> Read();
        Studios Read(string id);
        void Update(Studios game);
    }
}