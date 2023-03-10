namespace Account_Origination_Demo.Models;

public class CheckingOption
{
    public List<CheckingOptions> ListOfCheckingOptions()
    {
        return new List<CheckingOptions>
        {
            new CheckingOptions("Yes, add Checking with Overdraft Protection Transfer Service", "YesWithOverdraft"),
            new CheckingOptions("Yes, add Checking with no Overdraft Protection Transfer Service", "YesWithNoOverdraft"),
            new CheckingOptions("No, I would not like Checking", "NoChecking"),
        };
    }

    public List<PaperCheckOption> ListOfPaperCheckOptions()
    {
        return new List<PaperCheckOption>
        {
            new PaperCheckOption("Yes", "yes"),
            new PaperCheckOption("No", "no"),

        };
    }

    public List<DebitPinOption> ListOfDebitPinOptions()
    {
        return new List<DebitPinOption>
        {
            new DebitPinOption("Create my debit card PIN for me", "auto"),
            new DebitPinOption("I'd like to create my own debit card PIN", "manual"),
        };
    }

    public List<PrePrintedChecks> ListOfPrePrintedChecksOptions()
    {
        return new List<PrePrintedChecks>
        {
            new PrePrintedChecks("Yes", "yesPrePrintedChecks"),
            new PrePrintedChecks("No", "noPrePrintedChecks"),
        };
    }

    public record PrePrintedChecks(string Name, string Values);
    public record DebitPinOption(string Name, string Values);
    public record PaperCheckOption(string Name, string Values);
    public record CheckingOptions(string Name, string Values);
}