using System.ComponentModel.DataAnnotations;

namespace All_Up.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:50)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string Description { get; set; }
        [Required]
        [StringLength(maximumLength: 50)]
        public string ImageUrl { get; set; }
    }
}
