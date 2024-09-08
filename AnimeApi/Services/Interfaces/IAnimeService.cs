using AnimeApi.Models;

namespace AnimeApi.Services.Interfaces
{
    public interface IAnimeService
    {
        List<Anime> GetAnimeNumCapcher(int chapters);
        List<Anime> GetAnimeName(string name);
        List<Anime> GetAnimeYear(int year);
        bool DeleteAnimeName(string name);
    }
}
