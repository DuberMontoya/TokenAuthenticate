using AnimeApi.Models;
using AnimeApi.Repositories.Interfaces;
using AnimeApi.Services.Interfaces;

namespace AnimeApi.Services
{
    public class MusicService : IMusicService
    {
        private IMusicRepository _musicRepository;

        public MusicService(IMusicRepository musicRepository)
        {
            _musicRepository = musicRepository;
        }

        public bool DeleteMusicAnimeName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            return _musicRepository.DeleteMusicAnimeName(name);
        }

        public List<Music> GetMusicAnimeAuthor(string author)
        {
            if (string.IsNullOrWhiteSpace(author))
            {
                return new List<Music>();
            }
            return _musicRepository.GetMusicAnimeAuthor(author);
        }

        public List<Music> GetMusicAnimeCategory(string category)
        {
            if (string.IsNullOrWhiteSpace(category))
            {
                return new List<Music>();
            }
            return _musicRepository.GetMusicAnimeCategory(category);
        }

        public List<Music> GetMusicAnimeName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return new List<Music>();
            }
            return _musicRepository.GetMusicAnimeName(name);
        }
    }
}
