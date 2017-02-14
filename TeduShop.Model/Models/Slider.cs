using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TeduShop.Model
{
    [Table("Sliders")]
    public class Slider
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(256)]
        public string Name { get; set; }
        [Required]
        [MaxLength(256)]
        public string Description { get; set; }
        [Required]
        [MaxLength(256)]
        public string Image { get; set; }

        [Required]
        [MaxLength(256)]
        public string Url { get; set; }

        public int? Display { get; set; }
        public bool? Status { get; set; }
    }
}