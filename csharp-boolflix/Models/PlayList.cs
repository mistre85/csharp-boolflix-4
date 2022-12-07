using csharp_boolflix.Data.Models;
using Microsoft.EntityFrameworkCore.Storage;
using Newtonsoft.Json.Bson;

namespace csharp_boolflix.Models
{
    //il context
    public class PlayList
    {
        public string Titolo { get; set; }

        public IPlaylistContentStrategy Strategy { get; set; }

        public List<Media> GetContent()
        {
            return Strategy.Execute();
        }

    }

    public interface IPlaylistContentStrategy
    {
        public List<Media> Execute();
    }

    public class ResumeVideoContentPlayList : IPlaylistContentStrategy
    {
        public List<Media> Execute()
        {
            throw new NotImplementedException();
        }
    }

    public class CategoryVideoContentPlaylist : IPlaylistContentStrategy
    {
        public List<Media> Execute()
        {
            throw new NotImplementedException();
        }
    }


}
