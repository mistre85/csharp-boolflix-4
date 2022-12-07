namespace csharp_boolflix.Data.Models
{
    public abstract class Media
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; } 

        public virtual int Duration { get; set; }

        public int PlaybackPoint { get; set; }
    }
}
