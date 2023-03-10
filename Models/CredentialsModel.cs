using System.ComponentModel.DataAnnotations;

namespace Account_Origination_Demo.Models

{
    public class CredentialsModel
    {
        [EmailAddress]
        [Required(ErrorMessage = "Missing Email Address") ]
        public string? Username { get; set; }

        [Required]
        [MinLength(8)]
        public string? Password { get; set; }

        [Required]
        [Compare("Password")]
        public string? ConfirmPassword { get; set; }
    }
}
