namespace Account_Origination_Demo.Models;

public class StateData
{
    public List<States> ListStates()
    {
        return new List<States>
        {
            new States("", ""),
            new States("Alabama", "AL"),
            new States("Alaska", "AK"),
            new States("Arizona", "AZ"),
            new States("Arkansas", "AR"),
            new States("California", "CA"),
            new States("Colorado", "CO"),
            new States("Connecticut", "CT"),
            new States("Delaware", "DE"),
            new States("District Of Columbia", "DC"),
            new States("Florida", "FL"),
            new States("Georgia", "GA"),
            new States("Hawaii", "HI"),
            new States("Idaho", "ID"),
            new States("Illinois", "IL"),
            new States("Indiana", "IN"),
            new States("Iowa", "IA"),
            new States("Kansas", "KS"),
            new States("Kentucky", "KY"),
            new States("Louisiana", "LA"),
            new States("Maine", "ME"),
            new States("Maryland", "MD"),
            new States("Massachusetts", "MA"),
            new States("Michigan", "MI"),
            new States("Minnesota", "MN"),
            new States("Mississippi", "MS"),
            new States("Missouri", "MO"),
            new States("Montana", "MT"),
            new States("Nebraska", "NE"),
            new States("Nevada", "NV"),
            new States("New Hampshire", "NH"),
            new States("New Jersey", "NJ"),
            new States("New Mexico", "NM"),
            new States("New York", "NY"),
            new States("North Carolina", "NC"),
            new States("North Dakota", "ND"),
            new States("Ohio", "OH"),
            new States("Oklahoma", "OK"),
            new States("Oregon", "OR"),
            new States("Pennsylvania", "PA"),
            new States("Rhode Island", "RI"),
            new States("South Carolina", "SC"),
            new States("South Dakota", "SD"),
            new States("Tennessee", "TN"),
            new States("Texas", "TX"),
            new States("Utah", "UT"),
            new States("Vermont", "VT"),
            new States("Virginia", "VA"),
            new States("Washington", "WA"),
            new States("West Virginia", "WV"),
            new States("Wisconsin", "WI"),
            new States("Wyoming", "WY")
        };
    }
    public record States(string Name, string Values);
}