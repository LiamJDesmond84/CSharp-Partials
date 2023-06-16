using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace CSharp_Partials.Models
{
    public class Product
    {
        [Required]
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
