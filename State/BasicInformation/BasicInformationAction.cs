namespace Account_Origination_Demo.State
{
    public class BasicInformationAction
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string? Ssn { get; }
        public DateTime? DateOfBirth { get; }
        public string? PhoneNumber { get; }

        public BasicInformationAction(string firstname, string lastname,  string ssn, DateTime? dateofbirth, string? phoneNumber )
        {
            FirstName = firstname;
            LastName = lastname;
            Ssn = ssn;
            DateOfBirth = dateofbirth;
            PhoneNumber = phoneNumber;
        }
    }
}