using AnimeApi.Models;

namespace AnimeApi.Services.Interfaces
{
    public interface ICharapterService
    {
        List<Charapter> GetCharapterMoodOrBad(string moodBad);
        List<Charapter> GetCharacterName(string name);
        List<Charapter> GetCharacterAge(int age);
        bool DeleteCharacterName(string name);
    }
}
