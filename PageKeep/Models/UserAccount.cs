using System.ComponentModel.DataAnnotations;

namespace PageKeep.Models
{
    public class UserAccount
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Používateľské meno je povinné")]
        [MaxLength(50, ErrorMessage = "Používateľské meno nesmie byť dlhšie ako 50 znakov")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Heslo je povinné")]
        [MaxLength(100, ErrorMessage = "Heslo nesmie byť dlhšie ako 100 znakov")]
        public string? PasswordHash { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email je povinný")]
        [MaxLength(100, ErrorMessage = "Email nesmie byť dlhší ako 100 znakov")]
        [EmailAddress(ErrorMessage = "Neplatný formát emailu")]
        public string Email { get; set; } = string.Empty;

        public string Role { get; set; } = "User";
    }
}