using AnimeApi.Models;

namespace AnimeApi.Repositories.Interfaces
{
    public interface IMusicRepository
    {
        List<Music> GetMusicAnimeName(string name);
        List<Music> GetMusicAnimeAuthor(string author);
        List<Music> GetMusicAnimeCategory(string category);
        bool DeleteMusicAnimeName(string name);
    }
}
