using Fluxor;

namespace Account_Origination_Demo.State
{
    [FeatureState]
    public class WizardProgressState
    {
       public string? WizardProgressStep { get; }
        private WizardProgressState() { }
        public WizardProgressState(string wizardProgressStep)
        {
            WizardProgressStep = wizardProgressStep;
        }
    }
}
