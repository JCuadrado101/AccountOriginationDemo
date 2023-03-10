using System.ComponentModel.DataAnnotations;

namespace Account_Origination_Demo.Models

{
    public class JointMemberModel
    {
        public JointMemberModel()
        {
            JointMailingAddress = new JointMailingAddress();
            JointCitizenship = new JointCitizenship();
        }

        public string? JointMemberOption { get; set; }
        public string? JointFirstName { get; set; }
        public string? JointLastName { get; set; }
        public DateTime? JointDateOfBirth { get; set; }
        public string? JointSSN { get; set; }

        [ValidateComplexType]
        public JointMailingAddress JointMailingAddress { get; set; }

        [ValidateComplexType]
        public JointCitizenship? JointCitizenship { get; set; }
    }

    public class JointMailingAddress
    {
        [Required(ErrorMessage = "Missing Mailing Address")]
        public string? Address { get; set; } = string.Empty;

        public string? LineTwoAddress { get; set; } = string.Empty;

        [Required(ErrorMessage = "Missing Mailing City")]
        public string? City { get; set; } = string.Empty;

        [Required(ErrorMessage = "Missing Mailing State")]
        public string? State { get; set; } = string.Empty;

        [Required(ErrorMessage = "Missing Mailing Zip Code")]
        public string? Zip { get; set; } = string.Empty;
    }

    public class JointCitizenship
    {
        public string? CurrentStatus { get; set; }
        public string? PoliticallyExposed { get; set; }
        public string? FamilyMemberPoliticallyExposed { get; set; }
        public string? LiveInForeignCountry { get; set; }
        public string? IsCitizenOfForeignCountry { get; set; }
        public string? CountryOfForeignCitizenship { get; set; }
    }

}
