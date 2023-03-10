using Fluxor;

namespace Account_Origination_Demo.State
{
    [FeatureState]
    public class BasicInformationState
    {
        public string? FirstName { get; }
        public string? LastName { get; }
        public string? Ssn { get; }
        public DateTime? DateOfBirth { get; }
        public string? PhoneNumber { get; }
        private BasicInformationState() { }
        public BasicInformationState(string firstname, string lastname, string? ssn, DateTime? dateofbirth, string? phoneNumber)
        {
            FirstName = firstname!;
            LastName = lastname!;
            Ssn = ssn!;
            DateOfBirth = dateofbirth;
            PhoneNumber = phoneNumber;
        }
    }
}
