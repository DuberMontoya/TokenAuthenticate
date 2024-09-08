using AnimeApi.Models;
using AnimeApi.Repositories.Interfaces;
using AnimeApi.Utilities;
using System.Drawing;
using System.Xml.Linq;

namespace AnimeApi.Repositories
{
    public class AnimeRepository : IAnimeRepository
    {
        public List<Anime> AnimeList { get; set; }
        public AnimeRepository()
        {
            AnimeList = new List<Anime>()
            {
                new Anime() {Id = Guid.NewGuid(), Name = "Naruto", Genre = Genre.Action, NumChapter = 220, Year = 2002},
                new Anime() {Id = Guid.NewGuid(),Name = "One Piece", Genre = Genre.Adventure, NumChapter = 1080, Year = 1999},
                new Anime() {Id = Guid.NewGuid(), Name = "Attack on Titan", Genre = Genre.Fantasy, NumChapter = 95, Year = 2013},
                new Anime() {Id = Guid.NewGuid(), Name = "Made in Abyss", Genre = Genre.Drama, NumChapter = 17, Year = 2017},
            };
        }

        public List<Anime> GetAnimeNumChapter(int num)
        {
            return AnimeList.Where(e => e.NumChapter <= num).ToList();
        }

        public List<Anime> GetAnimeName(string name)
        {
            
            var filter = AnimeList.Where(e => e.Name.ToLower() == name.ToLower()).ToList();
            return filter;
        }

        public List<Anime> GetAnimeYear(int year)
        {
            var filter = AnimeList.Where(e => e.Year >= year).ToList();
            return filter;
        }

        public bool DeleteAnimeName(string name)
        {
            var anime = AnimeList.FirstOrDefault(a => a.Name.ToLower() == name.ToLower());
            if (anime != null)
            {
                AnimeList.Remove(anime);
                return true;
            }
            return false;
        }
    }
}   
