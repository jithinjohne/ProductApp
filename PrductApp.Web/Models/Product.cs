using System.ComponentModel.DataAnnotations;

namespace ProductApp.Web.Models
{
    public partial class Product
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public decimal? Price { get; set; }
        [Required] [Range(minimum: int.MinValue, maximum: int.MaxValue, ErrorMessage = "Please enter a value greater than or equal to zero")]
        public int? Stock { get; set; }
        [Required]
        public string Color { get; set; }
    }
}
