using System.ComponentModel.DataAnnotations;

namespace Mekashron.Models
{
    public class LoginVM
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        public LoginResponse Response { get; set; }
    }
}
