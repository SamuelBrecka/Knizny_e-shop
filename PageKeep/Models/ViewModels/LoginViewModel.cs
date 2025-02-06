using System.ComponentModel.DataAnnotations;

namespace PageKeep.Models.ViewModels
{
    public class LoginViewModel
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Zadajte meno")]
        public string? UserName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Zadajte heslo")]
        public string? Password { get; set; }
    }
}
