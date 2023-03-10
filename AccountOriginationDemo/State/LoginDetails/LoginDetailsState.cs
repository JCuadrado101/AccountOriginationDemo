using Fluxor;

namespace Account_Origination_Demo.State
{
    [FeatureState]
    public class LoginDetailsState
    {
        public string? Username { get; }
        public string? Password { get; }
        public string? ConfirmPassword { get; }

        private LoginDetailsState() { }

        public LoginDetailsState(string username, string password, string confirmPassword)
        {
            Username = username;
            Password = password;
            ConfirmPassword = confirmPassword;
        }
    }
}
