using csharp_boolflix.Data.Models;

namespace csharp_boolflix.Models
{
    public class Actor
    {
        public int Id { get; set; }

        public string FristName { get; set; }

        public string LastName { get; set; }

        public List<MediaExtended>? Medias { get; set; }
 
    }
}