using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using bemusic.Entities;

namespace bemusic.Models
{
    public class CreateAlbumDto
    {
        [Required]
        [MaxLength(80)]
        public string ArtistName { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        [MaxLength(30)]
        public string Version { get; set; }
        public int ReleaseYear { get; set; }

        [Required]
        public int SupplierId { get; set; }
        public List<Track> Tracks { get; set; }
    }
}
