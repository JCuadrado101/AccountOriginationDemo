using System.ComponentModel.DataAnnotations;

namespace Account_Origination_Demo.Models

{
    public class CreditCardModel
    {

        public string? AccountFundingOptions { get; set; }

        [Required(ErrorMessage = "Missing Funding Amount.")]
        [RegularExpression(@"^\b(0*(?:[1-9][0-9]?|100))\b", ErrorMessage = "Please enter an amount less than or equal to $100")]

        public string? DepositAmount { get; set; }

        [Required(ErrorMessage = "Missing Cardholder Name.")]
        public string? Cardholder { get; set; }

        [Required(ErrorMessage = "Missing Card Number")]
        public string? CardNumber { get; set; }

        [Required(ErrorMessage = "Missing Security Code")]
        public string? SecurityCode { get; set; }

        [Required(ErrorMessage = "Missing Expiration Number")]
        public string? ExpNumber { get; set; }

        [Required(ErrorMessage = "Missing Billing Zip Code")]
        public string? ZipCode { get; set; }
    }
}
