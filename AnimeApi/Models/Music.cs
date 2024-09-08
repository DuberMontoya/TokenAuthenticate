using AnimeApi.Utilities;

namespace AnimeApi.Models
{
    public class Music
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string BelongsAnime { get; set; }
        public string Author { get; set; }
        public string Category { get; set; }
        public string Duration { get; set; }
    }
}
