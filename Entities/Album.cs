using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace bemusic.Entities
{
    public class Album
    {
        
        public int Id { get; set; }
        
        [Required]
        [MaxLength(80)]
        public string ArtistName { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        [MaxLength (30)]
        public string Version { get; set; }

        public int ReleaseYear { get; set; }

        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }

        public virtual List<Track> Tracks { get; set; }


    }
}
