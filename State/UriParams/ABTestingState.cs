using Fluxor;

namespace Account_Origination_Demo.State
{
    [FeatureState]
    public class ABTestingState
    {
       public string? ABTestingParam { get; }
        private ABTestingState() { }
        public ABTestingState(string abTestingParam)
        {
            ABTestingParam = abTestingParam;
        }
    }
}
