using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EcommerceB.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Display Name")]
        [MaxLength(30)]
        public string? Name { get; set; }
        [Required]
        [Display(Name = "Display Order")]
        [Range(1, 100, ErrorMessage ="Number must be between 1 to 100")]
        public int DisplayOrder { get; set; }
    }
}
