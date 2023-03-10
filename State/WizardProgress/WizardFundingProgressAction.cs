namespace Account_Origination_Demo.State
{    public class WizardFundingProgressAction
    {
        public string WizardFundingProgressStep { get; }       
        public WizardFundingProgressAction(string wizardFundingProgressStep)
        {
            WizardFundingProgressStep = wizardFundingProgressStep;
        }
    }
}