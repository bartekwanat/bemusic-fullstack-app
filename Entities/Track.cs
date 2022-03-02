using System.ComponentModel.DataAnnotations;

namespace bemusic.Entities
{
    public class Track
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(80)]
        public string ArtistName { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        public int ReleaseYear { get; set; }

        public int Duration { get; set; }

        public int AlbumId { get; set; }
       
    }
}
