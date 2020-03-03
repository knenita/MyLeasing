using System.ComponentModel.DataAnnotations;

namespace MyLeasing.Web.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [EmailAddress]
        [Display(Name ="User Name")]
        public string Username { get; set; }

        [Required(ErrorMessage = "The field {0} is mandatory.")]
        [MinLength(6, ErrorMessage = "The {0} field must have at least {1} characters.")]
        public string Password { get; set; }

        [Display(Name = "Remenber Me")]
        public bool RememberMe { get; set; }
    }
}