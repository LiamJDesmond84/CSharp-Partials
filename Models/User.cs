using System.ComponentModel.DataAnnotations;

namespace CSharp_Partials.Models
{
    public class User
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
