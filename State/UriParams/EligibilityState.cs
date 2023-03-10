using Fluxor;

namespace Account_Origination_Demo.State
{
    [FeatureState]
    public class EligibilityState
    {
       public string? EligibilityParam { get; }
        private EligibilityState() { }
        public EligibilityState(string eligibilityParam)
        {
            EligibilityParam = eligibilityParam;
        }
    }
}
