namespace Account_Origination_Demo.Models;

public class JointMemberOptions
{
    public List<JointMemberOption> ListOfJointMemberOptions()
    {
        return new List<JointMemberOption>
        {
            new JointMemberOption("Yes", "yes"),
            new JointMemberOption("No", "yes"),
        };
    }
    public record JointMemberOption(string Name, string Values);
}