namespace Account_Origination_Demo.Models;

public class EmploymentStatus
{
    public List<EmployStatus> ListEmploymentStatuses()
    {
        return new List<EmployStatus>
        {
            new EmployStatus("", ""),
            new EmployStatus("Employed", "employed"),
            new EmployStatus("Retired", "retired"),
            new EmployStatus("Student", "student"),
            new EmployStatus("None of these", "none"),

        };
    }

    public record EmployStatus(string Name, string Values);

}