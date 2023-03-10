using Fluxor;

namespace Account_Origination_Demo.State
{
    [FeatureState]
    public class AddressInformationState
    {
        public string? ResidentialAddress { get; } 
        public string? ResidentialCity { get; } 
        public string? ResidentialState { get; }
        public string? ResidentialZipCode { get; }
        public bool IsMailingSameAsResidential { get; set; } = true;
        public string? MailingAddress { get; }
        public string? MailingCity { get; }
        public string? MailingState { get; }
        public string? MailingZipCode { get; }
        public string? CurrentStatus { get; set; }
        public string? PoliticallyExposed { get; set; }
        public string? FamilyMemberPoliticallyExposed { get; set; }
        public string? LiveInForeignCountry { get; set; }
        public string? IsCitizenOfForeignCountry { get; set;}
        public string? CountryOfForeignCitizenship { get; set; }

        public AddressInformationState() {}

        public AddressInformationState(
            string residentialAddress, string residentialCity,  string residentialState, string? residentialZipCode, bool isMailingSameAsResidential,
            string mailingAddress, string mailingCity, string mailingState, string mailingZipCode,string currentStatus, string politicallyExposed, string familyMemberPoliticallyExposed,
            string liveInForeignCountry, string isCitizenOfForeignCountry, string countryOfForeignCitizenship)
        {
            ResidentialAddress = residentialAddress;
            ResidentialCity = residentialCity;
            ResidentialState = residentialState;
            ResidentialZipCode = residentialZipCode;
            IsMailingSameAsResidential = isMailingSameAsResidential;
            MailingAddress = mailingAddress;
            MailingCity = mailingCity;
            MailingState = mailingState;
            MailingZipCode = mailingZipCode;
            CurrentStatus = currentStatus;
            PoliticallyExposed = politicallyExposed;
            FamilyMemberPoliticallyExposed = familyMemberPoliticallyExposed;
            LiveInForeignCountry = liveInForeignCountry;
            IsCitizenOfForeignCountry = isCitizenOfForeignCountry;
            CountryOfForeignCitizenship = countryOfForeignCitizenship;
        }
    }
}
