using AnimeApi.Models;
using AnimeApi.Repositories.Interfaces;
using AnimeApi.Utilities;

namespace AnimeApi.Repositories
{
    public class MusicRepository : IMusicRepository
    {
        public List<Music> MusicsList { get; set; }
        public MusicRepository()
        {
            MusicsList = new List<Music>()
            {
                new Music() {Id = Guid.NewGuid(), Name = "Cha-La Head-Cha-La", Author = "Hironobu Kageyama", BelongsAnime = "Dragon Ball Z", Category = "Opening", Duration = "3:17 min" },
                new Music() {Id = Guid.NewGuid(), Name = "We Are!", Author = "Hiroshi Kitadani", BelongsAnime = "One Piece", Category = "Opening", Duration = "4:03 min" },
                new Music() {Id = Guid.NewGuid(), Name = "Guren no Yumiya", Author = "Linked Horizon", BelongsAnime = "Attack on Titan", Category = "Opening", Duration = "5:15 min" },
                new Music() {Id = Guid.NewGuid(), Name = "Gurenge", Author = "LiSA", BelongsAnime = "Demon Slayer: Kimetsu no Yaiba", Category = "Opening", Duration = "3:38" },
                new Music() {Id = Guid.NewGuid(), Name = "Blue Bird", Author = "Ikimono Gakari", BelongsAnime = "Naruto", Category = "Opening", Duration = "3:38 min" },
            };
        }

        public List<Music> GetMusicAnimeName(string name)
        {
            return MusicsList.Where(e => e.Name.ToLower() == name.ToLower()).ToList();
        }

        public List<Music> GetMusicAnimeAuthor(string author)
        {
            return MusicsList.Where(e => e.Author.ToLower() == author.ToLower()).ToList();
        }

        public List<Music> GetMusicAnimeCategory(string category)
        {
            return MusicsList.Where(e => e.Category.ToLower() == category.ToLower()).ToList();
        }

        public bool DeleteMusicAnimeName(string name)
        {
            var music = MusicsList.FirstOrDefault(a => a.Name.ToLower() == name.ToLower());
            if (music != null)
            {
                MusicsList.Remove(music);
                return true;
            }
            return false;
        }
    }
}
