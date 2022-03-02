using System.ComponentModel.DataAnnotations;

namespace bemusic.Models
{
    public class UpdateAlbumtDto
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
    }
}
