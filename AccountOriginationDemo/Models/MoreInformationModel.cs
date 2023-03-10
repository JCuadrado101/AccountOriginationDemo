using System.ComponentModel.DataAnnotations;

namespace Account_Origination_Demo.Models

{
    public class MoreInformationModel
    {
        public MoreInformationModel()
        {
            MailingAddress = new MailingAddress();
            Citizenship = new Citizenship();
        }

        [Required(ErrorMessage = "Missing Residential Address.")]
        public string? ResidentialAddress { get; set; }

        public string? LineTwoAddress { get; set; }

        [Required(ErrorMessage = "Missing City.")]
        public string? City { get; set; }

        [Required(ErrorMessage = "Missing State.")]
        public string? State { get; set; }

        [Required(ErrorMessage = "Missing Zip Code.")]
        public string? Zip { get; set; }

        [Required]
        public bool IsMailingSameAsResidential { get; set; } = true;

        [ValidateComplexType]
        public MailingAddress? MailingAddress { get; set; }

        [ValidateComplexType]
        public Citizenship? Citizenship { get; set; }
    }

    public class MailingAddress
    {
        [Required(ErrorMessage = "Missing Mailing Address") ]
        public string? Address { get; set; } = string.Empty;

        public string? LineTwoAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = "Missing Mailing City") ]
        public string? City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Missing Mailing State") ]
        public string? State { get; set; } = string.Empty;

        [Required(ErrorMessage = "Missing Mailing Zip Code")]
        public string? Zip { get; set; } = string.Empty;
    }

    public class Citizenship
    {
        public string? CurrentStatus { get; set; }
        public string? PoliticallyExposed { get; set; }
        public string? FamilyMemberPoliticallyExposed { get; set; }
        public string? LiveInForeignCountry { get; set; }
        public string? IsCitizenOfForeignCountry { get; set;}
        public string? CountryOfForeignCitizenship { get; set; }
    }
}
