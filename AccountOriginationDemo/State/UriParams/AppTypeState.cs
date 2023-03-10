using Fluxor;

namespace Account_Origination_Demo.State
{
    [FeatureState]
    public class AppTypeState
    {
       public string? AppTypeParam { get; }
        private AppTypeState() { }
        public AppTypeState(string appTypeParam)
        {
            AppTypeParam = appTypeParam;
        }
    }
}
