using Fluxor;

namespace Account_Origination_Demo.State
{
    public static class Reducers
    {
        [ReducerMethod]
        public static WizardProgressState ReduceWizardProgressAction(WizardProgressState state, WizardProgressAction action) => new WizardProgressState(
            wizardProgressStep: action.WizardProgressStep
        );

        [ReducerMethod]
        public static WizardFundingProgressState ReduceWizardFundingProgressAction(WizardFundingProgressState state, WizardFundingProgressAction action) => new WizardFundingProgressState(
            wizardFundingProgressStep: action.WizardFundingProgressStep
        );

        [ReducerMethod]
        public static BasicInformationState ReduceBasicInformationAction(BasicInformationState state, BasicInformationAction action) => new BasicInformationState(
            firstname: action.FirstName,
            lastname: action.LastName,
            ssn: action.Ssn,
            dateofbirth: action.DateOfBirth,
            phoneNumber: action.PhoneNumber
        );

        [ReducerMethod]
        public static AddressInformationState ReduceAddressInformationAction(AddressInformationState state, AddressInformationAction action) => new AddressInformationState(
            residentialAddress: action.ResidentialAddress,
            residentialCity: action.ResidentialCity,
            residentialState: action.ResidentialState,
            residentialZipCode: action.ResidentialZipCode,
            isMailingSameAsResidential: action.IsMailingSameAsResidential,
            mailingAddress: action.MailingAddress!,
            mailingCity: action.MailingCity!,
            mailingState: action.MailingState!,
            mailingZipCode: action.MailingZipCode!,
            currentStatus: action.CurrentStatus!,
            politicallyExposed: action.PoliticallyExposed!,
            familyMemberPoliticallyExposed: action.FamilyMemberPoliticallyExposed!,
            liveInForeignCountry: action.LiveInForeignCountry!,
            isCitizenOfForeignCountry: action.IsCitizenOfForeignCountry!,
            countryOfForeignCitizenship: action.CountryOfForeignCitizenship!
        );

        [ReducerMethod]
        public static LoginDetailsState ReduceLoginDetailsAction(LoginDetailsState state, LoginDetailsAction action) => new LoginDetailsState(
            username: action.Username,
            password: action.Password,
            confirmPassword: action.ConfirmPassword
        );

        [ReducerMethod]
        public static ProductState ReduceProductAction(ProductState state, ProductAction action) => new ProductState(
            productParam: action.ProductParam
        );

        [ReducerMethod]
        public static AppTypeState ReduceAppTypeAction(AppTypeState state, AppTypeAction action) => new AppTypeState(
            appTypeParam: action.AppTypeParam
        );

        [ReducerMethod]
        public static ExistingMemberState ReduceExistingMemberAction(ExistingMemberState state, ExistingMemberAction action) => new ExistingMemberState(
            existingMemberParam: action.ExistingMemberParam
        );

        [ReducerMethod]
        public static EligibilityState ReduceEligibilityAction(EligibilityState state, EligibilityAction action) => new EligibilityState(
            eligibilityParam: action.EligibilityParam
        );

        [ReducerMethod]
        public static ABTestingState ReduceABTestingAction(ABTestingState state, ABTestingAction action) => new ABTestingState(
            abTestingParam: action.ABTestingParam
        );


    }
}