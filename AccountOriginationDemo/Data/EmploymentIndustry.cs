namespace Account_Origination_Demo.Models;

public class EmploymentIndustry
{
    public List<Industries> ListOfIndustries()
    {
        return new List<Industries>
        {
            new Industries("", ""),
            new Industries("Accommodation and Food Services", "1"),
            new Industries("Agriculture, Forestry, Fishing and Hunting", "2"),
            new Industries("All Other Services", "3"),
            new Industries("Arts, Entertainment and Recreation", "4"),
            new Industries("Construction", "5"),
            new Industries("Educational Services", "6"),
            new Industries("Finance and Insurance", "7"),
            new Industries("Healthcare and Social Assistance", "8"),
            new Industries("Information and Publishing including Data Processing, Video Production, Broadcasting and Libraries", "9"),
            new Industries("Management of Companies and Enterprises (Holding Companies)", "10"),
            new Industries("Manufacturing", "11"),
            new Industries("Mining", "12"),
            new Industries("Professional, Scientific and Technical Services", "13"),
            new Industries("Public Administration", "14"),
            new Industries("Real Estate, Rental or Leasing", "15"),
            new Industries("Retail Trade", "16"),
            new Industries("Transportation and Warehousing including Postal or Delivery Services", "17"),
            new Industries("Utilities", "18"),
            new Industries("Waste Management and Remediation Services", "19"),
            new Industries("Wholesale Trade", "20"),
        };
    }
    
    public record Industries(string Name, string Values);
}