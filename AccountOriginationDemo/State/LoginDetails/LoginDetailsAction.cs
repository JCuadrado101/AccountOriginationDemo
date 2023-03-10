namespace Account_Origination_Demo.State
{
    public class LoginDetailsAction
    {
        public string Username { get; }
        public string Password { get; }
        public string ConfirmPassword { get; }

        public LoginDetailsAction(string username, string password, string confirmPassword)
        {
            Username = username;
            Password = password;
            ConfirmPassword = confirmPassword;
        }
    }
}