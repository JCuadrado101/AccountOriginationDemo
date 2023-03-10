namespace Account_Origination_Demo.State
{    public class WizardJointProgressAction
    {
        public string WizardFundingProgressStep { get; }       
        public WizardJointProgressAction(string wizardFundingProgressStep)
        {
            WizardFundingProgressStep = wizardFundingProgressStep;
        }
    }
}