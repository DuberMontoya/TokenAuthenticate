using AnimeApi.Models;

namespace AnimeApi.Repositories.Interfaces
{
    public interface ICharapterRepository
    {
        List<Charapter> GetCharapterMoodOrBad(string moodBad);
        List<Charapter> GetCharacterName(string name);
        List<Charapter> GetCharacterAge(int age);
        bool DeleteCharacterName(string name);
    }
}
