namespace Account_Origination_Demo.State
{    public class ExistingMemberAction
    {
        public string ExistingMemberParam { get; }       
        public ExistingMemberAction(string existingMemberParam)
        {
            ExistingMemberParam = existingMemberParam;
        }
    }
}