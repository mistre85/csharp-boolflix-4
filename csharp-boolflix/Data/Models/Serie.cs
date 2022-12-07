using csharp_boolflix.Models;

namespace csharp_boolflix.Data.Models
{
    public class Serie : MediaExtended
    {

        public int SeasonsNumber { get; set; }

        public override int Duration
        {
            get
            {
                return Episodes.Count();
            }
        }

        public List<Episode> Episodes { get; set; }

       
    }
}
