using AnimeApi.Models;
using AnimeApi.Repositories.Interfaces;
using AnimeApi.Services.Interfaces;

namespace AnimeApi.Services
{
    public class CharapterService : ICharapterService
    {
        private ICharapterRepository _charapterRepository;

        public CharapterService(ICharapterRepository charapterRepository)
        {
            _charapterRepository = charapterRepository;
        }

        public bool DeleteCharacterName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return false;
            }
            return _charapterRepository.DeleteCharacterName(name);
        }

        public List<Charapter> GetCharacterAge(int age)
        {
            if (age <= 0)
            {
                return new List<Charapter>();
            }
            return _charapterRepository.GetCharacterAge(age);
        }

        public List<Charapter> GetCharacterName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return new List<Charapter>();
            }
            return _charapterRepository.GetCharacterName(name);
        }

        public List<Charapter> GetCharapterMoodOrBad(string moodBad)
        {
            if (string.IsNullOrWhiteSpace(moodBad))
            {
                return new List<Charapter>();
            }
            return _charapterRepository.GetCharapterMoodOrBad(moodBad);
        }
    }
}
