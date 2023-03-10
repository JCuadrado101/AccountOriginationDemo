using System.ComponentModel.DataAnnotations;

namespace Account_Origination_Demo.Models

{
    public class AgreementModel
    {
    [Required]
        [Range(typeof(bool), "true", "true", 
        ErrorMessage = "Must accept the disclosure and agreement to move forward.")]
        public bool IsDisclosureAccepted { get; set; }
    }
}
