using System.ComponentModel.DataAnnotations;

namespace bemusic.Models
{
    public class CreateTrackDto
    {
        [Required]
        [MaxLength(80)]
        public string ArtistName { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        public int ReleaseYear { get; set; }

        public int Duration { get; set; }

       
    }
}
