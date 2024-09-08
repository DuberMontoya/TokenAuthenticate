using AnimeApi.Models;
using AnimeApi.Repositories.Interfaces;

namespace AnimeApi.Repositories
{
    public class CharapterRepository : ICharapterRepository
    {
        public List<Charapter> CharapterList { get; set; }
        public CharapterRepository()
        {
            CharapterList = new List<Charapter>()
            {
                new Charapter() {Id = Guid.NewGuid(), Name = "Naruto Uzumaki", AnimeBelonging = "Naruto", MoodOrBad = "Bueno", Personality = "Optimista, leal, decidido", age = 17, Race = "humano", Weaknesse = "impulsividas, exceso de confianza" },
                new Charapter() {Id = Guid.NewGuid(), Name = "Goku", AnimeBelonging = "Dragon Ball z", MoodOrBad = "Bueno", Personality = "Protector", age = 43, Race = "Saiyan", Weaknesse = "inocencia" },
                new Charapter() {Id = Guid.NewGuid(), Name = "Saitama", AnimeBelonging = "One Punch Man", MoodOrBad = "Bueno", Personality = "Aburrido, despreocupado", age = 25, Race = "humano", Weaknesse = "Falta de motivación debido a su poder abrumador" },
                new Charapter() {Id = Guid.NewGuid(), Name = "Eren Yeager", AnimeBelonging = "Attack on Titan", MoodOrBad = "Malo", Personality = "Determinado, vengativo, impulsivo", age = 19, Race = "humano", Weaknesse = "Impulsividad, visión de túnel" },
                new Charapter() {Id = Guid.NewGuid(), Name = "Itachi Uchiha", AnimeBelonging = "Naruto", MoodOrBad = "Malo", Personality = "Misterioso", age = 28, Race = "humano", Weaknesse = "Enfermedad terminal, culpa por el pasado" },
            };
        }

        public List<Charapter> GetCharacterAge(int age)
        {
            var filter = CharapterList.Where(e => e.age <= age).ToList();
            return filter;
        }

        public List<Charapter> GetCharacterName(string name)
        {
            var filter = CharapterList.Where(e => e.Name.ToLower() == name.ToLower()).ToList();
            return filter;
        }

        public List<Charapter> GetCharapterMoodOrBad(string moodBad)
        {
            var filter = CharapterList.Where(e => e.MoodOrBad.ToLower() == moodBad.ToLower()).ToList();
            return filter;
        }

        public bool DeleteCharacterName(string name)
        {
            var anime = CharapterList.FirstOrDefault(a => a.Name.ToLower() == name.ToLower());
            if (anime != null)
            {
                CharapterList.Remove(anime);
                return true;
            }
            return false;
        }
    }
}
