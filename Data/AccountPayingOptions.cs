namespace Account_Origination_Demo.Models;



public class AccountPayingOptions
{
    public List<AccountPayment> ListOfAccountPayingOptions()
    {
        return new List<AccountPayment>
        {
            new AccountPayment("Yes", "yes"),
            new AccountPayment("No", "yes"),
        };
    }
    public record AccountPayment(string Name, string Values);
}