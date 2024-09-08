using AnimeApi.Models;

namespace AnimeApi.Services.Interfaces
{
    public interface IMusicService
    {
        List<Music> GetMusicAnimeName(string name);
        List<Music> GetMusicAnimeAuthor(string author);
        List<Music> GetMusicAnimeCategory(string category);
        bool DeleteMusicAnimeName(string name);
    }
}
