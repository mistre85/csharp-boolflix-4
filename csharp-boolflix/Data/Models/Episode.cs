using csharp_boolflix.Models;

namespace csharp_boolflix.Data.Models
{
    public class Episode : Media
    {
        public int SeasonNumber { get; set; }

        public int SerieId { get; set; }

        public Serie Serie { get; set; }

       
    }
}
