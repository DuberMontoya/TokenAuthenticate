using AnimeApi.Utilities;

namespace AnimeApi.Models
{
    public class Anime
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Genre Genre { get; set; }
        public int NumChapter { get; set; }
        public int Year { get; set; }

    }
}
