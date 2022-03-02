using System.ComponentModel.DataAnnotations;

namespace bemusic.Models
{
    public class CreateSupplierDto
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}