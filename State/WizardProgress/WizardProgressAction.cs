namespace Account_Origination_Demo.State
{    public class WizardProgressAction
    {
        public string WizardProgressStep { get; }       
        public WizardProgressAction(string wizardProgressStep)
        {
            WizardProgressStep = wizardProgressStep;
        }
    }
}