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
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Only positive numbers are allowed")]
        public int? Stock { get; set; }
        [Required]
        public string Color { get; set; }
    }
}
