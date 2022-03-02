using System.ComponentModel.DataAnnotations;

namespace bemusic.Entities
{
    public class Supplier
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
