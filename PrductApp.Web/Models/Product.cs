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
        [Required][Range(minimum:0,maximum:double.MaxValue,ErrorMessage = "Value should be greater than 0")]
        public int? Stock { get; set; }
        [Required]
        public string Color { get; set; }
    }
}
