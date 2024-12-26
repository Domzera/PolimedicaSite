using System.ComponentModel.DataAnnotations;

namespace Site_Polimedica.Models
{
    public class AppUser
    {
        [Key]
        public int id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string? Photo {  get; set; }
    }
}
