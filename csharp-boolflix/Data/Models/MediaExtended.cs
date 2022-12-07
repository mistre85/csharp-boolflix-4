using csharp_boolflix.Models;

namespace csharp_boolflix.Data.Models
{
    public abstract class MediaExtended : Media
    {
        public string Quality { get; set; }
        public string Anno { get; set; }

        public List<Actor> Actors { get; set; }

        public List<Genre> Genres { get; set; }

        public List<Features> Features { get; set; }
    }
}
