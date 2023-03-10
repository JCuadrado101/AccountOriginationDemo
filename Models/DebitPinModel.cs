using System.ComponentModel.DataAnnotations;

namespace Account_Origination_Demo.Models

{
    public class DebitPinModel
    {

        [MaxLength(4)]
        public string? DebitPin { get; set; }

        [Required]
        [Compare("DebitPin")]
        public string? ConfirmDebitPin { get; set; }
    }
}
