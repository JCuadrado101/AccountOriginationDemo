using Fluxor;

namespace Account_Origination_Demo.State
{
    [FeatureState]
    public class WizardFundingProgressState
    {
       public string? WizardFundingProgressStep { get; }
        private WizardFundingProgressState() { }
        public WizardFundingProgressState(string wizardFundingProgressStep)
        {
            WizardFundingProgressStep = wizardFundingProgressStep;
        }
    }
}
