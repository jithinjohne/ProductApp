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
        // Restricting Stock to accept only positive numbers
        [Range(0,int.MaxValue,ErrorMessage ="Please enter valid stock")]
        public int? Stock { get; set; }
        [Required]
        public string Color { get; set; }
    }
}
