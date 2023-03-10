using Fluxor;

namespace Account_Origination_Demo.State
{
    [FeatureState]
    public class ExistingMemberState
    {
       public string? ExistingMemberParam { get; }
        private ExistingMemberState() { }
        public ExistingMemberState(string existingMemberParam)
        {
            ExistingMemberParam = existingMemberParam;
        }
    }
}
