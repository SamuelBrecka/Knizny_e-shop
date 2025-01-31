using System.ComponentModel.DataAnnotations;

public class RegisterViewModel
{
    [Required(ErrorMessage = "Používateľské meno je povinné.")]
    public string UserName { get; set; }

    [Required(ErrorMessage = "E-mail je povinný.")]
    [EmailAddress(ErrorMessage = "Neplatný formát e-mailu.")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Heslo je povinné.")]
    [MinLength(6, ErrorMessage = "Heslo musí mať aspoň 6 znakov.")]
    public string Password { get; set; }

    [Required(ErrorMessage = "Potvrdenie hesla je povinné.")]
    [Compare(nameof(Password), ErrorMessage = "Heslá sa musia zhodovať.")]
    public string ConfirmPassword { get; set; }
}