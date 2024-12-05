using Lemoncode.Soccer.Domain;

namespace Lemoncode.Soccer.Infra.Contract
{
    public interface IGamesRepository
    {
        IEnumerable<Game> GetGames();
        Game GetGame(Guid id);
        void AddGame(Game game);
        void RemoveGame(Guid id);
        void UpdateGame(Guid id, Game game);
    }
}
