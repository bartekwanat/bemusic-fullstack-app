using System.Collections.Generic;
using bemusic.Entities;

namespace bemusic.Models
{
    public class AlbumDto
    {
        public int Id { get; set; }
        public string ArtistName { get; set; }
        public string Title { get; set; }
        public string Version { get; set; }
        public int ReleaseYear { get; set; }
        public int SupplierId { get; set; }
        public List<Track> Tracks { get; set; }
    }
}
