using Fluxor;

namespace Account_Origination_Demo.State
{
    [FeatureState]
    public class WizardJointProgressState
    {
       public string? WizardFundingProgressStep { get; }
        private WizardJointProgressState() { }
        public WizardJointProgressState(string wizardFundingProgressStep)
        {
            WizardFundingProgressStep = wizardFundingProgressStep;
        }
    }
}
