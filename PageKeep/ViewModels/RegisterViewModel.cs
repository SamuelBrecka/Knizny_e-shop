using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace PageKeep.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Používateľské meno je povinné.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Meno musí mať 3-50 znakov.")]
        [RegularExpression(@"^[a-zA-Z0-9_]+$", ErrorMessage = "Povolené sú len písmená, čísla a podtržník.")]
        public string UserName { get; set; } = string.Empty;

        [Required(ErrorMessage = "E-mail je povinný.")]
        [EmailAddress(ErrorMessage = "Neplatný formát e-mailu.")]
        [StringLength(100, ErrorMessage = "E-mail nesmie byť dlhší ako 100 znakov.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Heslo je povinné.")]
        [MinLength(6, ErrorMessage = "Heslo musí mať aspoň 6 znakov.")]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{6,}$",
            ErrorMessage = "Heslo musí obsahovať veľké písmeno, malé písmeno a číslicu.")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Potvrdenie hesla je povinné.")]
        [Compare(nameof(Password), ErrorMessage = "Heslá sa musia zhodovať.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}