using System.ComponentModel.DataAnnotations;

namespace PageKeep.Models
{
    public class UserAccount
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Username { get; set; }

        [Required]
        [MaxLength(100)]
        public string PasswordHash { get; set; } 

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        public string Role { get; set; } = "User";
    }
}