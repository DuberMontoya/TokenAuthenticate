using AnimeApi.Models;
using AnimeApi.Repositories.Interfaces;
using AnimeApi.Services.Interfaces;

namespace AnimeApi.Services
{
    public class AnimeService : IAnimeService
    {
        private IAnimeRepository _animeRepository;

        public AnimeService(IAnimeRepository animeRepository)
        {
            _animeRepository = animeRepository;
        }

        public bool DeleteAnimeName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            return _animeRepository.DeleteAnimeName(name);
        }

        public List<Anime> GetAnimeName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return new List<Anime>();
            }
            return _animeRepository.GetAnimeName(name);
        }

        public List<Anime> GetAnimeNumCapcher(int chapters)
        {
            if (chapters <= 0)
            {
                return new List<Anime>(); 
            }
            return _animeRepository.GetAnimeNumChapter(chapters);
        }

        public List<Anime> GetAnimeYear(int year)
        {
            if (year <= 1916)
            {
                return new List<Anime>();
            }
            return _animeRepository.GetAnimeYear(year);
        }
    }
}
