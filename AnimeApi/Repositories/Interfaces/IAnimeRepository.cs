using AnimeApi.Models;

namespace AnimeApi.Repositories.Interfaces
{
    public interface IAnimeRepository
    {
        List<Anime> GetAnimeNumChapter(int chapters);
        List<Anime> GetAnimeName(string name);
        List<Anime> GetAnimeYear(int year);
        bool DeleteAnimeName(string name);
    }
}
