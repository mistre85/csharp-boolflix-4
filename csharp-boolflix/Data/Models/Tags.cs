using csharp_boolflix.Data.Models;

namespace csharp_boolflix.Models
{
    public abstract class Tags
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public List<MediaExtended>? Medias { get; set; }
    }
}
