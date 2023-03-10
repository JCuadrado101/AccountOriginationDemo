namespace Account_Origination_Demo.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Temperatures
    {
        [JsonProperty("journey_application_token")]
        public string? JourneyApplicationToken { get; set; }

        [JsonProperty("external_partner_id")]
        public object? ExternalPartnerId { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("sandbox")]
        public bool Sandbox { get; set; }

        [JsonProperty("created_at")]
        public long CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public long UpdatedAt { get; set; }

        [JsonProperty("closed_at")]
        public long ClosedAt { get; set; }

        [JsonProperty("recent_outcome")]
        public object? RecentOutcome { get; set; }

        [JsonProperty("complete_outcome")]
        public string? CompleteOutcome { get; set; }

        [JsonProperty("journey_application_status")]
        public string? JourneyApplicationStatus { get; set; }

        [JsonProperty("is_archived")]
        public bool IsArchived { get; set; }

        [JsonProperty("is_escalated")]
        public bool IsEscalated { get; set; }

        [JsonProperty("archived_at")]
        public object? ArchivedAt { get; set; }

        [JsonProperty("terminal_reconciliation_output")]
        public TerminalReconciliationOutput? TerminalReconciliationOutput { get; set; }

        [JsonProperty("_embedded")]
        public TemperaturesEmbedded? Embedded { get; set; }

        [JsonProperty("_links")]
        public TemperaturesLinks? Links { get; set; }
    }

    public partial class TemperaturesEmbedded
    {
        [JsonProperty("child_entities")]
        public ChildEntity[]? ChildEntities { get; set; }

        [JsonProperty("entity_applications")]
        public EntityApplication[]? EntityApplications { get; set; }

        [JsonProperty("entity")]
        public Entity? Entity { get; set; }

        [JsonProperty("events")]
        public Event[]? Events { get; set; }

        [JsonProperty("journey")]
        public Journey? Journey { get; set; }
    }

    public partial class ChildEntity
    {
        [JsonProperty("external_entity_identifier")]
        public string? ExternalEntityIdentifier { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("token")]
        public string? Token { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("entity_application_token")]
        public string? EntityApplicationToken { get; set; }

        [JsonProperty("entity_application_status")]
        public string? EntityApplicationStatus { get; set; }

        [JsonProperty("entity_application_outcome")]
        public string? EntityApplicationOutcome { get; set; }

        [JsonProperty("created")]
        public string? Created { get; set; }
    }

    public partial class Entity
    {
        [JsonProperty("external_entity_identifier")]
        public object? ExternalEntityIdentifier { get; set; }

        [JsonProperty("name")]
        public object? Name { get; set; }

        [JsonProperty("token")]
        public string? Token { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }
    }

    public partial class EntityApplication
    {
        [JsonProperty("entity_token")]
        public string? EntityToken { get; set; }

        [JsonProperty("entity_application_token")]
        public string? EntityApplicationToken { get; set; }

        [JsonProperty("entity_application_outcome")]
        public string? EntityApplicationOutcome { get; set; }

        [JsonProperty("entity_application_status")]
        public string? EntityApplicationStatus { get; set; }

        [JsonProperty("entity_application_status_details")]
        public object? EntityApplicationStatusDetails { get; set; }

        [JsonProperty("external_entity_identifier")]
        public string? ExternalEntityIdentifier { get; set; }

        [JsonProperty("output")]
        public Output? Output { get; set; }
    }

    public partial class Output
    {
        [JsonProperty("outcome_reasons")]
        public object?[]? OutcomeReasons { get; set; }

        [JsonProperty("tags")]
        public string?[]? Tags { get; set; }

        [JsonProperty("output_attributes")]
        public TerminalReconciliationOutput? OutputAttributes { get; set; }

        [JsonProperty("matrix_models")]
        public TerminalReconciliationOutput? MatrixModels { get; set; }
    }

    public partial class TerminalReconciliationOutput
    {
    }

    public partial class Event
    {
        [JsonProperty("journey_application_event_token")]
        public string? JourneyApplicationEventToken { get; set; }

        [JsonProperty("journey_application_token")]
        public string? JourneyApplicationToken { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("entity_token")]
        public string? EntityToken { get; set; }

        [JsonProperty("entity_application_token")]
        public string? EntityApplicationToken { get; set; }

        [JsonProperty("_embedded")]
        public EventEmbedded? Embedded { get; set; }

        [JsonProperty("_links")]
        public EventLinks? Links { get; set; }

        [JsonProperty("evaluation_token", NullValueHandling = NullValueHandling.Ignore)]
        public string? EvaluationToken { get; set; }

        [JsonProperty("evaluation_tokens_sorted_by_created_dec", NullValueHandling = NullValueHandling.Ignore)]
        public string?[]? EvaluationTokensSortedByCreatedDec { get; set; }

        [JsonProperty("outcome", NullValueHandling = NullValueHandling.Ignore)]
        public string? Outcome { get; set; }

        [JsonProperty("evaluation_result", NullValueHandling = NullValueHandling.Ignore)]
        public EvaluationResult? EvaluationResult { get; set; }

        [JsonProperty("evaluation_data_by_evaluation_token", NullValueHandling = NullValueHandling.Ignore)]
        public EvaluationDataByEvaluationToken? EvaluationDataByEvaluationToken { get; set; }
    }

    public partial class EventEmbedded
    {
        [JsonProperty("node")]
        public Node? Node { get; set; }
    }

    public partial class Node
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public object? Name { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("config", NullValueHandling = NullValueHandling.Ignore)]
        public Config? Config { get; set; }

        [JsonProperty("workflow_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? WorkflowName { get; set; }
    }

    public partial class Config
    {
        [JsonProperty("application_token", NullValueHandling = NullValueHandling.Ignore)]
        public string? ApplicationToken { get; set; }

        [JsonProperty("workflow_token", NullValueHandling = NullValueHandling.Ignore)]
        public string? WorkflowToken { get; set; }

        [JsonProperty("application_version_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ApplicationVersionId { get; set; }

        [JsonProperty("workflow_version_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? WorkflowVersionId { get; set; }

        [JsonProperty("workflow_type", NullValueHandling = NullValueHandling.Ignore)]
        public string? WorkflowType { get; set; }

        [JsonProperty("workflow_current_version")]
        public object? WorkflowCurrentVersion { get; set; }

        [JsonProperty("outcome", NullValueHandling = NullValueHandling.Ignore)]
        public string? Outcome { get; set; }
    }

    public partial class EvaluationDataByEvaluationToken
    {
        [JsonProperty("S-WPnscRu6jScESlCBKMLa", NullValueHandling = NullValueHandling.Ignore)]
        public SWPnscRu6JScESlCbkmLa? SWPnscRu6JScESlCbkmLa { get; set; }

        [JsonProperty("S-CYNGglFj1NiaLHlpWfmM", NullValueHandling = NullValueHandling.Ignore)]
        public SCynGglFj1NiaLHlpWfmM? SCynGglFj1NiaLHlpWfmM { get; set; }

        [JsonProperty("S-MIp5Dgl5N6Oie0blr9cQ", NullValueHandling = NullValueHandling.Ignore)]
        public SMIp5Dgl5N6Oie0Blr9CQ? SMIp5Dgl5N6Oie0Blr9CQ { get; set; }
    }

    public partial class SCynGglFj1NiaLHlpWfmM
    {
        [JsonProperty("error")]
        public object? Error { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("evaluation_token")]
        public string? EvaluationToken { get; set; }

        [JsonProperty("entity_token")]
        public string? EntityToken { get; set; }

        [JsonProperty("parent_entity_token")]
        public object? ParentEntityToken { get; set; }

        [JsonProperty("group_token")]
        public string? GroupToken { get; set; }

        [JsonProperty("external_entity_id")]
        public string? ExternalEntityId { get; set; }

        [JsonProperty("application_token")]
        public string? ApplicationToken { get; set; }

        [JsonProperty("application_version_id")]
        public long ApplicationVersionId { get; set; }

        [JsonProperty("champion_challenger_id")]
        public object? ChampionChallengerId { get; set; }

        [JsonProperty("summary")]
        public SCynGglFj1NiaLHlpWfmMSummary? Summary { get; set; }

        [JsonProperty("supplied")]
        public Supplied? Supplied { get; set; }

        [JsonProperty("formatted")]
        public Formatted? Formatted { get; set; }

        [JsonProperty("matching")]
        public SCynGglFj1NiaLHlpWfmMMatching? Matching { get; set; }

        [JsonProperty("diligence")]
        public SCynGglFj1NiaLHlpWfmMDiligence? Diligence { get; set; }

        [JsonProperty("related_data")]
        public SCynGglFj1NiaLHlpWfmMRelatedData? RelatedData { get; set; }

        [JsonProperty("raw_responses")]
        public SCynGglFj1NiaLHlpWfmMRawResponses? RawResponses { get; set; }

        [JsonProperty("formatted_responses")]
        public SCynGglFj1NiaLHlpWfmMFormattedResponses? FormattedResponses { get; set; }

        [JsonProperty("audit_archive")]
        public object? AuditArchive { get; set; }
    }

    public partial class SCynGglFj1NiaLHlpWfmMDiligence
    {
        [JsonProperty("watchlists")]
        public object? Watchlists { get; set; }

        [JsonProperty("fraud")]
        public PurpleFraud? Fraud { get; set; }

        [JsonProperty("financial")]
        public object? Financial { get; set; }

        [JsonProperty("identity_questions")]
        public object? IdentityQuestions { get; set; }

        [JsonProperty("device")]
        public object? Device { get; set; }
    }

    public partial class PurpleFraud
    {
        [JsonProperty("average_score")]
        public double AverageScore { get; set; }

        [JsonProperty("flags")]
        public object[]? Flags { get; set; }

        [JsonProperty("sources")]
        public PurpleSources? Sources { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public partial class PurpleSources
    {
        [JsonProperty("ID Analytics ID Score")]
        public IdAnalyticsIdScore? IdAnalyticsIdScore { get; set; }

        [JsonProperty("Ekata")]
        public Ekata? Ekata { get; set; }

        [JsonProperty("Sentilink")]
        public Ekata? Sentilink { get; set; }

        [JsonProperty("Socure 30")]
        public SourcesSocure30? Socure30 { get; set; }
    }

    public partial class Ekata
    {
        [JsonProperty("normalized_score")]
        public long NormalizedScore { get; set; }

        [JsonProperty("raw_score")]
        public long RawScore { get; set; }

        [JsonProperty("attribute")]
        public string? Attribute { get; set; }
    }

    public partial class IdAnalyticsIdScore
    {
        [JsonProperty("normalized_score")]
        public double NormalizedScore { get; set; }

        [JsonProperty("raw_score")]
        public long RawScore { get; set; }

        [JsonProperty("attribute")]
        public string? Attribute { get; set; }
    }

    public partial class SourcesSocure30
    {
        [JsonProperty("normalized_score")]
        public double NormalizedScore { get; set; }

        [JsonProperty("raw_score")]
        public double RawScore { get; set; }

        [JsonProperty("attribute")]
        public string? Attribute { get; set; }
    }

    public partial class Formatted
    {
        [JsonProperty("name_first")]
        public string? NameFirst { get; set; }

        [JsonProperty("name_last")]
        public string? NameLast { get; set; }

        [JsonProperty("document_ssn")]
        public string? DocumentSsn { get; set; }

        [JsonProperty("birth_date")]
        public string? BirthDate { get; set; }

        [JsonProperty("address_line_1")]
        public string? AddressLine1 { get; set; }

        [JsonProperty("address_city")]
        public string? AddressCity { get; set; }

        [JsonProperty("address_state")]
        public string? AddressState { get; set; }

        [JsonProperty("address_postal_code")]
        public string? AddressPostalCode { get; set; }

        [JsonProperty("address_country_code")]
        public string? AddressCountryCode { get; set; }

        [JsonProperty("neuro_user_id")]
        public string? NeuroUserId { get; set; }

        [JsonProperty("site_id")]
        public string? SiteId { get; set; }

        [JsonProperty("identifiers")]
        public Identifiers? Identifiers { get; set; }

        [JsonProperty("age")]
        public string? Age { get; set; }
    }

    public partial class Identifiers
    {
        [JsonProperty("external_entity_id")]
        public string? ExternalEntityId { get; set; }
    }

    public partial class SCynGglFj1NiaLHlpWfmMFormattedResponses
    {
        [JsonProperty("NeuroId V2")]
        public FormattedResponsesNeuroIdV2? NeuroIdV2 { get; set; }

        [JsonProperty("ID Analytics ID Score")]
        public FormattedResponsesIdAnalyticsIdScore? IdAnalyticsIdScore { get; set; }

        [JsonProperty("Ekata")]
        public FormattedResponsesEkata? Ekata { get; set; }

        [JsonProperty("Sentilink")]
        public FormattedResponsesSentilink? Sentilink { get; set; }

        [JsonProperty("Socure 30")]
        public FormattedResponsesSocure30? Socure30 { get; set; }
    }

    public partial class FormattedResponsesEkata
    {
        [JsonProperty("data")]
        public TerminalReconciliationOutput? Data { get; set; }

        [JsonProperty("matching")]
        public EkataMatching? Matching { get; set; }
    }

    public partial class EkataMatching
    {
        [JsonProperty("address")]
        public AddressValue? Address { get; set; }
    }

    public partial class AddressValue
    {
        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("matched")]
        public bool Matched { get; set; }
    }

    public partial class FormattedResponsesIdAnalyticsIdScore
    {
        [JsonProperty("data")]
        public IdAnalyticsIdScoreData? Data { get; set; }

        [JsonProperty("matching")]
        public TerminalReconciliationOutput? Matching { get; set; }
    }

    public partial class IdAnalyticsIdScoreData
    {
        [JsonProperty("idScore")]
        public long IdScore { get; set; }

        [JsonProperty("consumerStatement")]
        public string? ConsumerStatement { get; set; }

        [JsonProperty("reason_codes")]
        public string?[]? ReasonCodes { get; set; }
    }

    public partial class FormattedResponsesNeuroIdV2
    {
        [JsonProperty("data")]
        public NeuroIdV2Data? Data { get; set; }
    }

    public partial class NeuroIdV2Data
    {
        [JsonProperty("intent")]
        public double Intent { get; set; }

        [JsonProperty("fraud_ring_indicator")]
        public double FraudRingIndicator { get; set; }

        [JsonProperty("automated_activity")]
        public bool AutomatedActivity { get; set; }

        [JsonProperty("fraud_ring_indicator_v2")]
        public bool FraudRingIndicatorV2 { get; set; }

        [JsonProperty("intent_label")]
        public string? IntentLabel { get; set; }
    }

    public partial class FormattedResponsesSentilink
    {
        [JsonProperty("data")]
        public SentilinkData? Data { get; set; }
    }

    public partial class SentilinkData
    {
        [JsonProperty("scores")]
        public Scores? Scores { get; set; }

        [JsonProperty("reasonCodes")]
        public ReasonCodes? ReasonCodes { get; set; }

        [JsonProperty("consumer_history")]
        public ConsumerHistory? ConsumerHistory { get; set; }

        [JsonProperty("years_since_filing_date")]
        public long YearsSinceFilingDate { get; set; }
    }

    public partial class ConsumerHistory
    {
        [JsonProperty("shared_ssn_count")]
        public long SharedSsnCount { get; set; }

        [JsonProperty("number_of_ssns")]
        public long NumberOfSsns { get; set; }
    }

    public partial class ReasonCodes
    {
        [JsonProperty("allReasonCodes")]
        public object[]? AllReasonCodes { get; set; }

        [JsonProperty("moreFraudyCodes")]
        public object[]? MoreFraudyCodes { get; set; }

        [JsonProperty("lessFraudyCodes")]
        public object[]? LessFraudyCodes { get; set; }
    }

    public partial class Scores
    {
        [JsonProperty("sentilink_abuse_score")]
        public long SentilinkAbuseScore { get; set; }

        [JsonProperty("sentilink_first_party_synthetic_score")]
        public long SentilinkFirstPartySyntheticScore { get; set; }

        [JsonProperty("sentilink_third_party_synthetic_score")]
        public long SentilinkThirdPartySyntheticScore { get; set; }
    }

    public partial class FormattedResponsesSocure30
    {
        [JsonProperty("data")]
        public Socure30_Data? Data { get; set; }

        [JsonProperty("matching")]
        public Socure30_Matching? Matching { get; set; }
    }

    public partial class Socure30_Data
    {
        [JsonProperty("reasonCodes")]
        public object[]? ReasonCodes { get; set; }

        [JsonProperty("watchLists")]
        public WatchLists? WatchLists { get; set; }

        [JsonProperty("fraudScores")]
        public FraudScores? FraudScores { get; set; }

        [JsonProperty("kycValidation")]
        public KycValidation? KycValidation { get; set; }

        [JsonProperty("global_watchlist")]
        public GlobalWatchlist? GlobalWatchlist { get; set; }

        [JsonProperty("eCBSV")]
        public Dictionary<string, bool>? ECbsv { get; set; }

        [JsonProperty("error_message_type_2")]
        public string? ErrorMessageType2 { get; set; }

        [JsonProperty("error_message")]
        public string? ErrorMessage { get; set; }
    }

    public partial class FraudScores
    {
        [JsonProperty("generic")]
        public double Generic { get; set; }

        [JsonProperty("sigma")]
        public double Sigma { get; set; }

        [JsonProperty("sigmaSynthetic")]
        public double SigmaSynthetic { get; set; }
    }

    public partial class GlobalWatchlist
    {
        [JsonProperty("r180")]
        public bool R180 { get; set; }

        [JsonProperty("r181")]
        public bool R181 { get; set; }

        [JsonProperty("r183")]
        public bool R183 { get; set; }

        [JsonProperty("r182")]
        public bool R182 { get; set; }

        [JsonProperty("r186")]
        public bool R186 { get; set; }

        [JsonProperty("r185")]
        public bool R185 { get; set; }

        [JsonProperty("r184")]
        public bool R184 { get; set; }
    }

    public partial class KycValidation
    {
        [JsonProperty("firstName")]
        public bool FirstName { get; set; }

        [JsonProperty("surName")]
        public bool SurName { get; set; }

        [JsonProperty("streetAddress")]
        public bool StreetAddress { get; set; }

        [JsonProperty("city")]
        public bool City { get; set; }

        [JsonProperty("state")]
        public bool State { get; set; }

        [JsonProperty("zip")]
        public bool Zip { get; set; }

        [JsonProperty("dob")]
        public bool Dob { get; set; }

        [JsonProperty("mobileNumber")]
        public bool MobileNumber { get; set; }

        [JsonProperty("ssn")]
        public bool Ssn { get; set; }
    }

    public partial class WatchLists
    {
        [JsonProperty("internationalPEP")]
        public long InternationalPep { get; set; }

        [JsonProperty("internationalOFAC")]
        public long InternationalOfac { get; set; }

        [JsonProperty("domesticPEP")]
        public long DomesticPep { get; set; }

        [JsonProperty("domesticOFAC")]
        public long DomesticOfac { get; set; }

        [JsonProperty("ofac")]
        public long Ofac { get; set; }

        [JsonProperty("adverseMedia")]
        public long AdverseMedia { get; set; }

        [JsonProperty("enforcement")]
        public long Enforcement { get; set; }
    }

    public partial class Socure30_Matching
    {
        [JsonProperty("email")]
        public EmailClass? Email { get; set; }

        [JsonProperty("name")]
        public EmailClass? Name { get; set; }

        [JsonProperty("address")]
        public EmailClass? Address { get; set; }

        [JsonProperty("dob")]
        public EmailClass? Dob { get; set; }

        [JsonProperty("phone")]
        public EmailClass? Phone { get; set; }

        [JsonProperty("ssn")]
        public EmailClass? Ssn { get; set; }
    }

    public partial class EmailClass
    {
        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("matched")]
        public bool Matched { get; set; }
    }

    public partial class SCynGglFj1NiaLHlpWfmMMatching
    {
        [JsonProperty("address")]
        public PurpleAddress? Address { get; set; }

        [JsonProperty("name")]
        public PurpleAddress? Name { get; set; }

        [JsonProperty("dob")]
        public PurpleAddress? Dob { get; set; }

        [JsonProperty("ssn")]
        public PurpleAddress? Ssn { get; set; }

        [JsonProperty("average_score")]
        public double AverageScore { get; set; }
    }

    public partial class PurpleAddress
    {
        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("matched")]
        public string?[]? Matched { get; set; }

        [JsonProperty("unmatched")]
        public object[]? Unmatched { get; set; }
    }

    public partial class SCynGglFj1NiaLHlpWfmMRawResponses
    {
        [JsonProperty("NeuroId V2")]
        public NeuroIdV2Element[]? NeuroIdV2 { get; set; }

        [JsonProperty("ID Analytics ID Score")]
        public IdAnalyticsIdScoreElement[]? IdAnalyticsIdScore { get; set; }

        [JsonProperty("Ekata")]
        public EkataElement[]? Ekata { get; set; }

        [JsonProperty("Sentilink")]
        public SentilinkElement[]? Sentilink { get; set; }

        [JsonProperty("Socure 30")]
        public Socure30_Element[]? Socure30 { get; set; }
    }

    public partial class EkataElement
    {
        [JsonProperty("request")]
        public Request? Request { get; set; }

        [JsonProperty("primary_phone_checks")]
        public object? PrimaryPhoneChecks { get; set; }

        [JsonProperty("secondary_phone_checks")]
        public object? SecondaryPhoneChecks { get; set; }

        [JsonProperty("primary_address_checks")]
        public PrimaryAddressChecks? PrimaryAddressChecks { get; set; }

        [JsonProperty("secondary_address_checks")]
        public object? SecondaryAddressChecks { get; set; }

        [JsonProperty("primary_email_address_checks")]
        public object? PrimaryEmailAddressChecks { get; set; }

        [JsonProperty("secondary_email_address_checks")]
        public object? SecondaryEmailAddressChecks { get; set; }

        [JsonProperty("ip_address_checks")]
        public object? IpAddressChecks { get; set; }

        [JsonProperty("identity_check_score")]
        public long IdentityCheckScore { get; set; }

        [JsonProperty("identity_network_score")]
        public double IdentityNetworkScore { get; set; }
    }

    public partial class PrimaryAddressChecks
    {
        [JsonProperty("error")]
        public object? Error { get; set; }

        [JsonProperty("warnings")]
        public object[]? Warnings { get; set; }

        [JsonProperty("is_valid")]
        public bool IsValid { get; set; }

        [JsonProperty("input_completeness")]
        public string? InputCompleteness { get; set; }

        [JsonProperty("match_to_name")]
        public string? MatchToName { get; set; }

        [JsonProperty("resident")]
        public Resident? Resident { get; set; }

        [JsonProperty("is_commercial")]
        public bool IsCommercial { get; set; }

        [JsonProperty("is_forwarder")]
        public bool IsForwarder { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }
    }

    public partial class Resident
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("age_range")]
        public AgeRange? AgeRange { get; set; }
    }

    public partial class AgeRange
    {
        [JsonProperty("from")]
        public long From { get; set; }

        [JsonProperty("to")]
        public long To { get; set; }
    }

    public partial class Request
    {
        [JsonProperty("primary.firstname")]
        public string? PrimaryFirstname { get; set; }

        [JsonProperty("primary.lastname")]
        public string? PrimaryLastname { get; set; }

        [JsonProperty("primary.address.street_line_1")]
        public string? PrimaryAddressStreetLine1 { get; set; }

        [JsonProperty("primary.address.city")]
        public string? PrimaryAddressCity { get; set; }

        [JsonProperty("primary.address.state_code")]
        public string? PrimaryAddressStateCode { get; set; }

        [JsonProperty("primary.address.postal_code")]
        public string? PrimaryAddressPostalCode { get; set; }

        [JsonProperty("primary.address.country_code")]
        public string? PrimaryAddressCountryCode { get; set; }

        [JsonProperty("secondary.firstname")]
        public string? SecondaryFirstname { get; set; }

        [JsonProperty("secondary.lastname")]
        public string? SecondaryLastname { get; set; }

        [JsonProperty("api_key")]
        public string? ApiKey { get; set; }
    }

    public partial class IdAnalyticsIdScoreElement
    {
        [JsonProperty("$")]
        public IdAnalyticsIdScoreClass? Empty { get; set; }

        [JsonProperty("api:Solution")]
        public string? ApiSolution { get; set; }

        [JsonProperty("api:RequestID")]
        public string? ApiRequestId { get; set; }

        [JsonProperty("api:View")]
        public string? ApiView { get; set; }

        [JsonProperty("api:Body")]
        public ApiBody? ApiBody { get; set; }
    }

    public partial class ApiBody
    {
        [JsonProperty("api:Item")]
        public ApiItemClass? ApiItem { get; set; }
    }

    public partial class ApiItemClass
    {
        [JsonProperty("$")]
        public ApiItem? Empty { get; set; }

        [JsonProperty("OutputRecord")]
        public OutputRecordClass? OutputRecord { get; set; }
    }

    public partial class ApiItem
    {
        [JsonProperty("key")]
        public string? Key { get; set; }
    }

    public partial class OutputRecordClass
    {
        [JsonProperty("$")]
        public OutputRecord? Empty { get; set; }

        [JsonProperty("IDAStatus")]
        public string? IdaStatus { get; set; }

        [JsonProperty("AppID")]
        public string? AppId { get; set; }

        [JsonProperty("Designation")]
        public string? Designation { get; set; }

        [JsonProperty("IDASequence")]
        public string? IdaSequence { get; set; }

        [JsonProperty("IDATimeStamp")]
        public string? IdaTimeStamp { get; set; }

        [JsonProperty("IDScore")]
        public string? IdScore { get; set; }

        [JsonProperty("IDScoreResultCode1")]
        public string? IdScoreResultCode1 { get; set; }

        [JsonProperty("IDScoreResultCode2")]
        public string? IdScoreResultCode2 { get; set; }

        [JsonProperty("IDScoreResultCode3")]
        public string? IdScoreResultCode3 { get; set; }
    }

    public partial class OutputRecord
    {
        [JsonProperty("xmlns")]
        public Uri? Xmlns { get; set; }

        [JsonProperty("xmlns:xsi")]
        public Uri? XmlnsXsi { get; set; }

        [JsonProperty("xmlns:internal")]
        public Uri? XmlnsInternal { get; set; }

        [JsonProperty("schemaVersion")]
        public string? SchemaVersion { get; set; }
    }

    public partial class IdAnalyticsIdScoreClass
    {
        [JsonProperty("xmlns:api")]
        public Uri? XmlnsApi { get; set; }
    }

    public partial class NeuroIdV2Element
    {
        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("profile")]
        public NeuroIdV2Profile? Profile { get; set; }

        [JsonProperty("")]
        public Empty? Empty { get; set; }
    }

    public partial class Empty
    {
        [JsonProperty("profile")]
        public Profile? Profile { get; set; }
    }

    public partial class Profile
    {
        [JsonProperty("signals")]
        public PurpleSignal[]? Signals { get; set; }
    }

    public partial class PurpleSignal
    {
        [JsonProperty("label")]
        public string? Label { get; set; }
    }

    public partial class NeuroIdV2Profile
    {
        [JsonProperty("siteId")]
        public string? SiteId { get; set; }

        [JsonProperty("funnel")]
        public string? Funnel { get; set; }

        [JsonProperty("clientId")]
        public string? ClientId { get; set; }

        [JsonProperty("clientIdCardinality")]
        public long ClientIdCardinality { get; set; }

        [JsonProperty("signals")]
        public FluffySignal[]? Signals { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }
    }

    public partial class FluffySignal
    {
        [JsonProperty("model")]
        public string? Model { get; set; }

        [JsonProperty("score", NullValueHandling = NullValueHandling.Ignore)]
        public double? Score { get; set; }

        [JsonProperty("version", NullValueHandling = NullValueHandling.Ignore)]
        public string? Version { get; set; }

        [JsonProperty("label", NullValueHandling = NullValueHandling.Ignore)]
        public string? Label { get; set; }

        [JsonProperty("attributes", NullValueHandling = NullValueHandling.Ignore)]
        public TerminalReconciliationOutput? Attributes { get; set; }
    }

    public partial class SentilinkElement
    {
        [JsonProperty("transaction_id")]
        public string? TransactionId { get; set; }

        [JsonProperty("application_id")]
        public string? ApplicationId { get; set; }

        [JsonProperty("scores")]
        public SentilinkScore[]? Scores { get; set; }

        [JsonProperty("customer_id")]
        public string? CustomerId { get; set; }

        [JsonProperty("environment")]
        public string? Environment { get; set; }

        [JsonProperty("notes")]
        public string? Notes { get; set; }

        [JsonProperty("timestamp")]
        public string? Timestamp { get; set; }

        [JsonProperty("latency_ms")]
        public long LatencyMs { get; set; }
    }

    public partial class SentilinkScore
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("version")]
        public string? Version { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }
    }

    public partial class Socure30_Element
    {
        [JsonProperty("referenceId")]
        public string? ReferenceId { get; set; }

        [JsonProperty("alertList")]
        public AlertList? AlertList { get; set; }

        [JsonProperty("nameAddressCorrelation")]
        public NameCorrelation? NameAddressCorrelation { get; set; }

        [JsonProperty("nameEmailCorrelation")]
        public NameCorrelation? NameEmailCorrelation { get; set; }

        [JsonProperty("namePhoneCorrelation")]
        public NameCorrelation? NamePhoneCorrelation { get; set; }

        [JsonProperty("fraud")]
        public Socure30_Fraud? Fraud { get; set; }

        [JsonProperty("synthetic")]
        public Synthetic? Synthetic { get; set; }

        [JsonProperty("kyc")]
        public Kyc? Kyc { get; set; }

        [JsonProperty("social")]
        public Socure30_Social? Social { get; set; }

        [JsonProperty("addressRisk")]
        public Risk? AddressRisk { get; set; }

        [JsonProperty("emailRisk")]
        public Risk? EmailRisk { get; set; }

        [JsonProperty("phoneRisk")]
        public Risk? PhoneRisk { get; set; }

        [JsonProperty("prefill")]
        public Prefill? Prefill { get; set; }

        [JsonProperty("error")]
        public Error? Error { get; set; }

        [JsonProperty("deviceRisk")]
        public DeviceRisk? DeviceRisk { get; set; }
    }

    public partial class Risk
    {
        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("reasonCodes")]
        public object[]? ReasonCodes { get; set; }
    }

    public partial class AlertList
    {
        [JsonProperty("reasonCodes")]
        public object[]? ReasonCodes { get; set; }

        [JsonProperty("matches")]
        public object[]? Matches { get; set; }
    }

    public partial class DeviceRisk
    {
        [JsonProperty("score")]
        public long Score { get; set; }
    }

    public partial class Error
    {
        [JsonProperty("msg")]
        public string? Msg { get; set; }
    }

    public partial class Socure30_Fraud
    {
        [JsonProperty("reasonCodes")]
        public object[]? ReasonCodes { get; set; }

        [JsonProperty("scores")]
        public FraudScore[]? Scores { get; set; }
    }

    public partial class FraudScore
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("version")]
        public string? Version { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public partial class Kyc
    {
        [JsonProperty("reasonCodes")]
        public object[]? ReasonCodes { get; set; }

        [JsonProperty("fieldValidations")]
        public Dictionary<string, double>? FieldValidations { get; set; }
    }

    public partial class NameCorrelation
    {
        [JsonProperty("reasonCodes")]
        public object[]? ReasonCodes { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public partial class Prefill
    {
        [JsonProperty("firstName")]
        public string? FirstName { get; set; }

        [JsonProperty("surName")]
        public string? SurName { get; set; }

        [JsonProperty("middleName")]
        public string? MiddleName { get; set; }

        [JsonProperty("suffix")]
        public string? Suffix { get; set; }

        [JsonProperty("dob")]
        public string? Dob { get; set; }

        [JsonProperty("streetAddress")]
        public string? StreetAddress { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("zip")]
        public string? Zip { get; set; }

        [JsonProperty("associatedAddresses")]
        public AssociatedAddress[]? AssociatedAddresses { get; set; }
    }

    public partial class AssociatedAddress
    {
        [JsonProperty("streetAddress")]
        public string? StreetAddress { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("zip")]
        public string? Zip { get; set; }
    }

    public partial class Socure30_Social
    {
        [JsonProperty("profilesFound")]
        public Uri[]? ProfilesFound { get; set; }

        [JsonProperty("reasonCodes")]
        public object[]? ReasonCodes { get; set; }
    }

    public partial class Synthetic
    {
        [JsonProperty("scores")]
        public FraudScore[]? Scores { get; set; }
    }

    public partial class SCynGglFj1NiaLHlpWfmMRelatedData
    {
        [JsonProperty("social")]
        public SocialElement[]? Social { get; set; }
    }

    public partial class SocialElement
    {
        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("url")]
        public Uri? Url { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }
    }

    public partial class SCynGglFj1NiaLHlpWfmMSummary
    {
        [JsonProperty("result")]
        public string? Result { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("tags")]
        public object[]? Tags { get; set; }

        [JsonProperty("outcome_reasons")]
        public object[]? OutcomeReasons { get; set; }

        [JsonProperty("outcome")]
        public string? Outcome { get; set; }

        [JsonProperty("services")]
        public PurpleServices? Services { get; set; }

        [JsonProperty("alloy_fraud_score")]
        public object? AlloyFraudScore { get; set; }
    }

    public partial class PurpleServices
    {
        [JsonProperty("NeuroId V2")]
        public string? NeuroIdV2 { get; set; }

        [JsonProperty("ID Analytics ID Score")]
        public string? IdAnalyticsIdScore { get; set; }

        [JsonProperty("Socure 30")]
        public string? Socure30 { get; set; }

        [JsonProperty("Sentilink")]
        public string? Sentilink { get; set; }

        [JsonProperty("Ekata")]
        public string? Ekata { get; set; }
    }

    public partial class Supplied
    {
        [JsonProperty("name_first")]
        public string? NameFirst { get; set; }

        [JsonProperty("name_last")]
        public string? NameLast { get; set; }

        [JsonProperty("document_ssn")]
        public string? DocumentSsn { get; set; }

        [JsonProperty("birth_date")]
        public string? BirthDate { get; set; }

        [JsonProperty("address_line_1")]
        public string? AddressLine1 { get; set; }

        [JsonProperty("address_city")]
        public string? AddressCity { get; set; }

        [JsonProperty("address_state")]
        public string? AddressState { get; set; }

        [JsonProperty("address_postal_code")]
        public string? AddressPostalCode { get; set; }

        [JsonProperty("address_country_code")]
        public string? AddressCountryCode { get; set; }

        [JsonProperty("neuro_user_id")]
        public string? NeuroUserId { get; set; }

        [JsonProperty("site_id")]
        public string? SiteId { get; set; }

        [JsonProperty("identifiers")]
        public Identifiers? Identifiers { get; set; }
    }

    public partial class SMIp5Dgl5N6Oie0Blr9CQ
    {
        [JsonProperty("error")]
        public object? Error { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("evaluation_token")]
        public string? EvaluationToken { get; set; }

        [JsonProperty("entity_token")]
        public string? EntityToken { get; set; }

        [JsonProperty("parent_entity_token")]
        public object? ParentEntityToken { get; set; }

        [JsonProperty("group_token")]
        public string? GroupToken { get; set; }

        [JsonProperty("external_entity_id")]
        public string? ExternalEntityId { get; set; }

        [JsonProperty("application_token")]
        public string? ApplicationToken { get; set; }

        [JsonProperty("application_version_id")]
        public long ApplicationVersionId { get; set; }

        [JsonProperty("champion_challenger_id")]
        public object? ChampionChallengerId { get; set; }

        [JsonProperty("summary")]
        public SMIp5Dgl5N6Oie0Blr9CQSummary? Summary { get; set; }

        [JsonProperty("supplied")]
        public Supplied? Supplied { get; set; }

        [JsonProperty("formatted")]
        public Formatted? Formatted { get; set; }

        [JsonProperty("matching")]
        public SMIp5Dgl5N6Oie0Blr9CQMatching? Matching { get; set; }

        [JsonProperty("diligence")]
        public SMIp5Dgl5N6Oie0Blr9CQDiligence? Diligence { get; set; }

        [JsonProperty("related_data")]
        public TerminalReconciliationOutput? RelatedData { get; set; }

        [JsonProperty("raw_responses")]
        public SMIp5Dgl5N6Oie0Blr9CQRawResponses? RawResponses { get; set; }

        [JsonProperty("formatted_responses")]
        public SMIp5Dgl5N6Oie0Blr9CQFormattedResponses? FormattedResponses { get; set; }

        [JsonProperty("audit_archive")]
        public object? AuditArchive { get; set; }
    }

    public partial class SMIp5Dgl5N6Oie0Blr9CQDiligence
    {
        [JsonProperty("watchlists")]
        public PurpleWatchlists? Watchlists { get; set; }

        [JsonProperty("fraud")]
        public object? Fraud { get; set; }

        [JsonProperty("financial")]
        public object? Financial { get; set; }

        [JsonProperty("identity_questions")]
        public object? IdentityQuestions { get; set; }

        [JsonProperty("device")]
        public object? Device { get; set; }
    }

    public partial class PurpleWatchlists
    {
        [JsonProperty("lists")]
        public string?[]? Lists { get; set; }

        [JsonProperty("matches")]
        public Match[]? Matches { get; set; }
    }

    public partial class Match
    {
        [JsonProperty("source")]
        public string? Source { get; set; }

        [JsonProperty("reason_listed")]
        public string?[]? ReasonListed { get; set; }

        [JsonProperty("details")]
        public Details? Details { get; set; }
    }

    public partial class Details
    {
        [JsonProperty("listing_started_utc")]
        public string? ListingStartedUtc { get; set; }

        [JsonProperty("name")]
        public NameClass? Name { get; set; }

        [JsonProperty("links")]
        public Uri[]? Links { get; set; }
    }

    public partial class NameClass
    {
        [JsonProperty("Full")]
        public string? Full { get; set; }
    }

    public partial class SMIp5Dgl5N6Oie0Blr9CQFormattedResponses
    {
        [JsonProperty("Lexis Nexis Instant ID")]
        public FormattedResponsesLexisNexisInstantId? LexisNexisInstantId { get; set; }

        [JsonProperty("ComplyAdvantage")]
        public FormattedResponsesComplyAdvantage? ComplyAdvantage { get; set; }
    }

    public partial class FormattedResponsesComplyAdvantage
    {
        [JsonProperty("data")]
        public ComplyAdvantageData? Data { get; set; }
    }

    public partial class ComplyAdvantageData
    {
        [JsonProperty("match_count")]
        public long MatchCount { get; set; }

        [JsonProperty("matched_lists")]
        public string?[]? MatchedLists { get; set; }

        [JsonProperty("matches")]
        public Match[]? Matches { get; set; }

        [JsonProperty("watchlist_categories")]
        public string?[]? WatchlistCategories { get; set; }
    }

    public partial class FormattedResponsesLexisNexisInstantId
    {
        [JsonProperty("matching")]
        public LexisNexisInstantIdMatching? Matching { get; set; }

        [JsonProperty("diligence")]
        public LexisNexisInstantIdDiligence? Diligence { get; set; }

        [JsonProperty("data")]
        public LexisNexisInstantIdData? Data { get; set; }
    }

    public partial class LexisNexisInstantIdData
    {
        [JsonProperty("watchlists")]
        public DataWatchlists? Watchlists { get; set; }

        [JsonProperty("identity_theft_risk")]
        public long IdentityTheftRisk { get; set; }

        [JsonProperty("risk_codes")]
        public string?[]? RiskCodes { get; set; }

        [JsonProperty("followup_codes")]
        public object[]? FollowupCodes { get; set; }

        [JsonProperty("address")]
        public DataAddress? Address { get; set; }

        [JsonProperty("ssn")]
        public Ssn? Ssn { get; set; }

        [JsonProperty("reverse_phone")]
        public ReversePhone? ReversePhone { get; set; }

        [JsonProperty("reverse_name_address")]
        public ReverseNameAddress? ReverseNameAddress { get; set; }

        [JsonProperty("verification")]
        public Dictionary<string, bool>? Verification { get; set; }
    }

    public partial class DataAddress
    {
        [JsonProperty("po_box")]
        public bool PoBox { get; set; }

        [JsonProperty("commercial_mail")]
        public bool CommercialMail { get; set; }
    }

    public partial class ReverseNameAddress
    {
        [JsonProperty("phone_number")]
        public long PhoneNumber { get; set; }
    }

    public partial class ReversePhone
    {
        [JsonProperty("name_first")]
        public string? NameFirst { get; set; }

        [JsonProperty("name_last")]
        public string? NameLast { get; set; }

        [JsonProperty("address_city")]
        public string? AddressCity { get; set; }

        [JsonProperty("address_state")]
        public string? AddressState { get; set; }

        [JsonProperty("address_postal_code_last5")]
        public string? AddressPostalCodeLast5 { get; set; }
    }

    public partial class Ssn
    {
        [JsonProperty("issuance_start_date")]
        public string? IssuanceStartDate { get; set; }

        [JsonProperty("issuance_end_date")]
        public string? IssuanceEndDate { get; set; }

        [JsonProperty("issuance_state")]
        public string? IssuanceState { get; set; }
    }

    public partial class DataWatchlists
    {
        [JsonProperty("pep")]
        public long Pep { get; set; }

        [JsonProperty("ofac")]
        public long Ofac { get; set; }
    }

    public partial class LexisNexisInstantIdDiligence
    {
        [JsonProperty("watchlists")]
        public FluffyWatchlists? Watchlists { get; set; }

        [JsonProperty("fraud")]
        public FluffyFraud? Fraud { get; set; }

        [JsonProperty("financial")]
        public Financial? Financial { get; set; }

        [JsonProperty("identity_questions")]
        public object? IdentityQuestions { get; set; }
    }

    public partial class Financial
    {
        [JsonProperty("credit")]
        public object? Credit { get; set; }

        [JsonProperty("banking")]
        public object? Banking { get; set; }
    }

    public partial class FluffyFraud
    {
        [JsonProperty("score")]
        public object? Score { get; set; }

        [JsonProperty("flags")]
        public object? Flags { get; set; }
    }

    public partial class FluffyWatchlists
    {
        [JsonProperty("lists")]
        public string?[]? Lists { get; set; }

        [JsonProperty("matches")]
        public object[]? Matches { get; set; }
    }

    public partial class LexisNexisInstantIdMatching
    {
        [JsonProperty("name")]
        public AddressValue? Name { get; set; }

        [JsonProperty("address")]
        public AddressValue? Address { get; set; }

        [JsonProperty("ssn")]
        public AddressValue? Ssn { get; set; }

        [JsonProperty("dob")]
        public AddressValue? Dob { get; set; }

        [JsonProperty("phone")]
        public AddressValue? Phone { get; set; }

        [JsonProperty("passport")]
        public AddressValue? Passport { get; set; }
    }

    public partial class SMIp5Dgl5N6Oie0Blr9CQMatching
    {
        [JsonProperty("name")]
        public FluffyAddress? Name { get; set; }

        [JsonProperty("address")]
        public FluffyAddress? Address { get; set; }

        [JsonProperty("ssn")]
        public FluffyAddress? Ssn { get; set; }

        [JsonProperty("dob")]
        public FluffyAddress? Dob { get; set; }

        [JsonProperty("average_score")]
        public long AverageScore { get; set; }
    }

    public partial class FluffyAddress
    {
        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("matched")]
        public string?[]? Matched { get; set; }

        [JsonProperty("unmatched")]
        public object[]? Unmatched { get; set; }
    }

    public partial class SMIp5Dgl5N6Oie0Blr9CQRawResponses
    {
        [JsonProperty("Lexis Nexis Instant ID")]
        public LexisNexisInstantIdElement[]? LexisNexisInstantId { get; set; }

        [JsonProperty("ComplyAdvantage")]
        public ComplyAdvantageElement[]? ComplyAdvantage { get; set; }
    }

    public partial class ComplyAdvantageElement
    {
        [JsonProperty("code")]
        public long Code { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("content")]
        public Content? Content { get; set; }
    }

    public partial class Content
    {
        [JsonProperty("data")]
        public ContentData? Data { get; set; }
    }

    public partial class ContentData
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("ref")]
        public string? Ref { get; set; }

        [JsonProperty("searcher_id")]
        public long SearcherId { get; set; }

        [JsonProperty("assignee_id")]
        public long AssigneeId { get; set; }

        [JsonProperty("filters")]
        public Filters? Filters { get; set; }

        [JsonProperty("match_status")]
        public string? MatchStatus { get; set; }

        [JsonProperty("risk_level")]
        public string? RiskLevel { get; set; }

        [JsonProperty("search_term")]
        public string? SearchTerm { get; set; }

        [JsonProperty("submitted_term")]
        public string? SubmittedTerm { get; set; }

        [JsonProperty("client_ref")]
        public object? ClientRef { get; set; }

        [JsonProperty("total_hits")]
        public long TotalHits { get; set; }

        [JsonProperty("updated_at")]
        public string? UpdatedAt { get; set; }

        [JsonProperty("created_at")]
        public string? CreatedAt { get; set; }

        [JsonProperty("tags")]
        public object[]? Tags { get; set; }

        [JsonProperty("limit")]
        public long Limit { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("searcher")]
        public Assignee? Searcher { get; set; }

        [JsonProperty("assignee")]
        public Assignee? Assignee { get; set; }

        [JsonProperty("hits")]
        public Hit[]? Hits { get; set; }
    }

    public partial class Assignee
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("phone")]
        public string? Phone { get; set; }

        [JsonProperty("created_at")]
        public string? CreatedAt { get; set; }
    }

    public partial class Filters
    {
        [JsonProperty("country_codes")]
        public object[]? CountryCodes { get; set; }

        [JsonProperty("remove_deceased")]
        public long RemoveDeceased { get; set; }

        [JsonProperty("types")]
        public object[]? Types { get; set; }

        [JsonProperty("exact_match")]
        public bool ExactMatch { get; set; }

        [JsonProperty("fuzziness")]
        public double Fuzziness { get; set; }
    }

    public partial class Hit
    {
        [JsonProperty("doc")]
        public Doc? Doc { get; set; }

        [JsonProperty("match_types")]
        public string?[]? MatchTypes { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public partial class Doc
    {
        [JsonProperty("aka")]
        public Aka[]? Aka { get; set; }

        [JsonProperty("assets")]
        public Asset[]? Assets { get; set; }

        [JsonProperty("associates")]
        public Associate[]? Associates { get; set; }

        [JsonProperty("entity_type")]
        public string? EntityType { get; set; }

        [JsonProperty("fields")]
        public Field[]? Fields { get; set; }

        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("keywords")]
        public object[]? Keywords { get; set; }

        [JsonProperty("last_updated_utc")]
        public string? LastUpdatedUtc { get; set; }

        [JsonProperty("media")]
        public Media[]? Media { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("source_notes")]
        public SourceNotes? SourceNotes { get; set; }

        [JsonProperty("sources")]
        public string?[]? Sources { get; set; }

        [JsonProperty("types")]
        public string?[]? Types { get; set; }
    }

    public partial class Aka
    {
        [JsonProperty("name")]
        public string? Name { get; set; }
    }

    public partial class Asset
    {
        [JsonProperty("public_url")]
        public Uri? PublicUrl { get; set; }

        [JsonProperty("source")]
        public string? Source { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }
    }

    public partial class Associate
    {
        [JsonProperty("association")]
        public string? Association { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }

    public partial class Field
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("source")]
        public string? Source { get; set; }

        [JsonProperty("tag")]
        public string? Tag { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }
    }

    public partial class Media
    {
        [JsonProperty("date")]
        public string? Date { get; set; }

        [JsonProperty("snippet")]
        public string? Snippet { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("url")]
        public Uri? Url { get; set; }
    }

    public partial class SourceNotes
    {
        [JsonProperty("OFAC SDN List")]
        public OfacSdnList? OfacSdnList { get; set; }
    }

    public partial class OfacSdnList
    {
        [JsonProperty("aml_types")]
        public string?[]? AmlTypes { get; set; }

        [JsonProperty("country_codes")]
        public string?[]? CountryCodes { get; set; }

        [JsonProperty("listing_started_utc")]
        public string? ListingStartedUtc { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }

    public partial class LexisNexisInstantIdElement
    {
        [JsonProperty("response")]
        public Response? Response { get; set; }
    }

    public partial class Response
    {
        [JsonProperty("Header")]
        public Header? Header { get; set; }

        [JsonProperty("Result")]
        public Result? Result { get; set; }
    }

    public partial class Header
    {
        [JsonProperty("Status")]
        public long Status { get; set; }

        [JsonProperty("TransactionId")]
        public string? TransactionId { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("InputEcho")]
        public InputEcho? InputEcho { get; set; }

        [JsonProperty("UniqueId")]
        public string? UniqueId { get; set; }

        [JsonProperty("NameAddressSSNSummary")]
        public long NameAddressSsnSummary { get; set; }

        [JsonProperty("AdditionalScore1")]
        public long AdditionalScore1 { get; set; }

        [JsonProperty("AdditionalScore2")]
        public long AdditionalScore2 { get; set; }

        [JsonProperty("PhoneOfNameAddress")]
        public long PhoneOfNameAddress { get; set; }

        [JsonProperty("SSNInfo")]
        public SsnInfo? SsnInfo { get; set; }

        [JsonProperty("CurrentName")]
        public CurrentNameClass? CurrentName { get; set; }

        [JsonProperty("ReversePhone")]
        public ReversePhoneClass? ReversePhone { get; set; }

        [JsonProperty("VerifiedInput")]
        public VerifiedInput? VerifiedInput { get; set; }

        [JsonProperty("ComprehensiveVerification")]
        public ComprehensiveVerification? ComprehensiveVerification { get; set; }

        [JsonProperty("NameAddressPhone")]
        public NameAddressPhone? NameAddressPhone { get; set; }

        [JsonProperty("AddressPOBox")]
        public bool AddressPoBox { get; set; }

        [JsonProperty("SSNFoundForLexID")]
        public bool SsnFoundForLexId { get; set; }

        [JsonProperty("AddressCMRA")]
        public bool AddressCmra { get; set; }

        [JsonProperty("DOBMatchLevel")]
        public long DobMatchLevel { get; set; }

        [JsonProperty("PassportValidated")]
        public bool PassportValidated { get; set; }

        [JsonProperty("InstantIDVersion")]
        public string? InstantIdVersion { get; set; }

        [JsonProperty("ChronologyHistories")]
        public ChronologyHistories? ChronologyHistories { get; set; }

        [JsonProperty("DOBVerified")]
        public bool DobVerified { get; set; }

        [JsonProperty("WatchLists")]
        public WatchListsClass? WatchLists { get; set; }
    }

    public partial class ChronologyHistories
    {
        [JsonProperty("ChronologyHistory")]
        public ChronologyHistory[]? ChronologyHistory { get; set; }
    }

    public partial class ChronologyHistory
    {
        [JsonProperty("Address")]
        public ChronologyHistoryAddress? Address { get; set; }

        [JsonProperty("DateLastSeen")]
        public IssuedEndDate? DateLastSeen { get; set; }

        [JsonProperty("DateFirstSeen")]
        public IssuedEndDate? DateFirstSeen { get; set; }

        [JsonProperty("IsBestAddress", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBestAddress { get; set; }

        [JsonProperty("Phone", NullValueHandling = NullValueHandling.Ignore)]
        public string? Phone { get; set; }
    }

    public partial class ChronologyHistoryAddress
    {
        [JsonProperty("City")]
        public string? City { get; set; }

        [JsonProperty("Zip4")]
        public string? Zip4 { get; set; }

        [JsonProperty("Zip5")]
        public string? Zip5 { get; set; }

        [JsonProperty("State")]
        public string? State { get; set; }

        [JsonProperty("StreetName", NullValueHandling = NullValueHandling.Ignore)]
        public string? StreetName { get; set; }

        [JsonProperty("UnitNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string? UnitNumber { get; set; }

        [JsonProperty("StreetNumber", NullValueHandling = NullValueHandling.Ignore)]
        public string? StreetNumber { get; set; }

        [JsonProperty("StreetSuffix", NullValueHandling = NullValueHandling.Ignore)]
        public string? StreetSuffix { get; set; }

        [JsonProperty("StreetAddress1")]
        public string? StreetAddress1 { get; set; }

        [JsonProperty("UnitDesignation", NullValueHandling = NullValueHandling.Ignore)]
        public string? UnitDesignation { get; set; }
    }

    public partial class IssuedEndDate
    {
        [JsonProperty("Year")]
        public string? Year { get; set; }

        [JsonProperty("Month")]
        public string? Month { get; set; }
    }

    public partial class ComprehensiveVerification
    {
        [JsonProperty("ComprehensiveVerificationIndex")]
        public long ComprehensiveVerificationIndex { get; set; }

        [JsonProperty("PotentialFollowupActions")]
        public PotentialFollowupActions? PotentialFollowupActions { get; set; }

        [JsonProperty("RiskIndicators")]
        public RiskIndicators? RiskIndicators { get; set; }
    }

    public partial class PotentialFollowupActions
    {
        [JsonProperty("FollowupAction")]
        public FollowupAction[]? FollowupAction { get; set; }
    }

    public partial class FollowupAction
    {
        [JsonProperty("RiskCode")]
        public string? RiskCode { get; set; }

        [JsonProperty("Description")]
        public string? Description { get; set; }
    }

    public partial class RiskIndicators
    {
        [JsonProperty("RiskIndicator")]
        public RiskIndicator[]? RiskIndicator { get; set; }
    }

    public partial class RiskIndicator
    {
        [JsonProperty("RiskCode")]
        public string? RiskCode { get; set; }

        [JsonProperty("Sequence")]
        public long Sequence { get; set; }

        [JsonProperty("Description")]
        public string? Description { get; set; }
    }

    public partial class CurrentNameClass
    {
        [JsonProperty("Last")]
        public string? Last { get; set; }

        [JsonProperty("First")]
        public string? First { get; set; }
    }

    public partial class InputEcho
    {
        [JsonProperty("SSN")]
        public string? Ssn { get; set; }

        [JsonProperty("SSNLast4")]
        public string? SsnLast4 { get; set; }

        [JsonProperty("IPAddress")]
        public string? IpAddress { get; set; }

        [JsonProperty("Name")]
        public CurrentNameClass? Name { get; set; }

        [JsonProperty("Address")]
        public InputEchoAddress? Address { get; set; }

        [JsonProperty("DOB")]
        public InputEchoDob? Dob { get; set; }

        [JsonProperty("Channel")]
        public object? Channel { get; set; }

        [JsonProperty("Passport")]
        public Passport? Passport { get; set; }

        [JsonProperty("DriverLicenseNumber")]
        public object? DriverLicenseNumber { get; set; }

        [JsonProperty("DriverLicenseState")]
        public object? DriverLicenseState { get; set; }

        [JsonProperty("HomePhone")]
        public string? HomePhone { get; set; }

        [JsonProperty("OwnOrRent")]
        public object? OwnOrRent { get; set; }

        [JsonProperty("ApplicationDateTime")]
        public ApplicationDateTime? ApplicationDateTime { get; set; }
    }

    public partial class InputEchoAddress
    {
        [JsonProperty("StreetAddress1")]
        public string? StreetAddress1 { get; set; }

        [JsonProperty("StreetAddress2")]
        public string? StreetAddress2 { get; set; }

        [JsonProperty("City")]
        public string? City { get; set; }

        [JsonProperty("State")]
        public string? State { get; set; }

        [JsonProperty("Zip5")]
        public string? Zip5 { get; set; }
    }

    public partial class ApplicationDateTime
    {
        [JsonProperty("Day")]
        public long Day { get; set; }

        [JsonProperty("Year")]
        public long Year { get; set; }

        [JsonProperty("Month")]
        public long Month { get; set; }

        [JsonProperty("Hour24")]
        public long Hour24 { get; set; }

        [JsonProperty("Minute")]
        public long Minute { get; set; }

        [JsonProperty("Second")]
        public long Second { get; set; }
    }

    public partial class InputEchoDob
    {
        [JsonProperty("Year")]
        public long Year { get; set; }

        [JsonProperty("Month")]
        public long Month { get; set; }

        [JsonProperty("Day")]
        public long Day { get; set; }
    }

    public partial class Passport
    {
        [JsonProperty("Number")]
        public string? Number { get; set; }

        [JsonProperty("Country")]
        public string? Country { get; set; }

        [JsonProperty("ExpirationDate")]
        public ExpirationDate? ExpirationDate { get; set; }

        [JsonProperty("MachineReadableLine1")]
        public string? MachineReadableLine1 { get; set; }

        [JsonProperty("MachineReadableLine2")]
        public string? MachineReadableLine2 { get; set; }
    }

    public partial class ExpirationDate
    {
        [JsonProperty("Year")]
        public object? Year { get; set; }

        [JsonProperty("Month")]
        public object? Month { get; set; }

        [JsonProperty("Day")]
        public object? Day { get; set; }
    }

    public partial class NameAddressPhone
    {
        [JsonProperty("Summary")]
        public string? Summary { get; set; }
    }

    public partial class ReversePhoneClass
    {
        [JsonProperty("Name")]
        public CurrentNameClass? Name { get; set; }

        [JsonProperty("Address")]
        public ReversePhoneAddress? Address { get; set; }
    }

    public partial class ReversePhoneAddress
    {
        [JsonProperty("City")]
        public string? City { get; set; }

        [JsonProperty("Zip5")]
        public string? Zip5 { get; set; }

        [JsonProperty("State")]
        public string? State { get; set; }

        [JsonProperty("StreetName")]
        public string? StreetName { get; set; }

        [JsonProperty("UnitNumber")]
        public string? UnitNumber { get; set; }

        [JsonProperty("StreetNumber")]
        public string? StreetNumber { get; set; }

        [JsonProperty("StreetSuffix")]
        public string? StreetSuffix { get; set; }

        [JsonProperty("StreetAddress1")]
        public string? StreetAddress1 { get; set; }

        [JsonProperty("UnitDesignation")]
        public string? UnitDesignation { get; set; }
    }

    public partial class SsnInfo
    {
        [JsonProperty("Valid")]
        public string? Valid { get; set; }

        [JsonProperty("IssuedEndDate")]
        public IssuedEndDate? IssuedEndDate { get; set; }

        [JsonProperty("IssuedLocation")]
        public string? IssuedLocation { get; set; }

        [JsonProperty("IssuedStartDate")]
        public IssuedEndDate? IssuedStartDate { get; set; }
    }

    public partial class VerifiedInput
    {
        [JsonProperty("DOB")]
        public VerifiedInputDob? Dob { get; set; }

        [JsonProperty("SSN")]
        public string? Ssn { get; set; }

        [JsonProperty("Name")]
        public CurrentNameClass? Name { get; set; }

        [JsonProperty("Address")]
        public VerifiedInputAddress? Address { get; set; }

        [JsonProperty("HomePhone")]
        public string? HomePhone { get; set; }
    }

    public partial class VerifiedInputAddress
    {
        [JsonProperty("City")]
        public string? City { get; set; }

        [JsonProperty("Zip4")]
        public string? Zip4 { get; set; }

        [JsonProperty("Zip5")]
        public string? Zip5 { get; set; }

        [JsonProperty("State")]
        public string? State { get; set; }

        [JsonProperty("StreetName")]
        public string? StreetName { get; set; }

        [JsonProperty("UnitNumber")]
        public string? UnitNumber { get; set; }

        [JsonProperty("StreetNumber")]
        public string? StreetNumber { get; set; }

        [JsonProperty("StreetSuffix")]
        public string? StreetSuffix { get; set; }

        [JsonProperty("StreetAddress1")]
        public string? StreetAddress1 { get; set; }

        [JsonProperty("UnitDesignation")]
        public string? UnitDesignation { get; set; }
    }

    public partial class VerifiedInputDob
    {
        [JsonProperty("Day")]
        public string? Day { get; set; }

        [JsonProperty("Year")]
        public string? Year { get; set; }

        [JsonProperty("Month")]
        public string? Month { get; set; }
    }

    public partial class WatchListsClass
    {
        [JsonProperty("WatchList")]
        public object[]? WatchList { get; set; }
    }

    public partial class SMIp5Dgl5N6Oie0Blr9CQSummary
    {
        [JsonProperty("result")]
        public string? Result { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("tags")]
        public string?[]? Tags { get; set; }

        [JsonProperty("outcome_reasons")]
        public object[]? OutcomeReasons { get; set; }

        [JsonProperty("outcome")]
        public string? Outcome { get; set; }

        [JsonProperty("services")]
        public FluffyServices? Services { get; set; }

        [JsonProperty("alloy_fraud_score")]
        public object? AlloyFraudScore { get; set; }
    }

    public partial class FluffyServices
    {
        [JsonProperty("ComplyAdvantage")]
        public string? ComplyAdvantage { get; set; }

        [JsonProperty("Lexis Nexis Instant ID")]
        public string? LexisNexisInstantId { get; set; }
    }

    public partial class SWPnscRu6JScESlCbkmLa
    {
        [JsonProperty("error")]
        public object? Error { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("evaluation_token")]
        public string? EvaluationToken { get; set; }

        [JsonProperty("entity_token")]
        public string? EntityToken { get; set; }

        [JsonProperty("parent_entity_token")]
        public object? ParentEntityToken { get; set; }

        [JsonProperty("group_token")]
        public string? GroupToken { get; set; }

        [JsonProperty("external_entity_id")]
        public string? ExternalEntityId { get; set; }

        [JsonProperty("application_token")]
        public string? ApplicationToken { get; set; }

        [JsonProperty("application_version_id")]
        public long ApplicationVersionId { get; set; }

        [JsonProperty("champion_challenger_id")]
        public object? ChampionChallengerId { get; set; }

        [JsonProperty("summary")]
        public SWPnscRu6JScESlCbkmLaSummary? Summary { get; set; }

        [JsonProperty("supplied")]
        public Supplied? Supplied { get; set; }

        [JsonProperty("formatted")]
        public Formatted? Formatted { get; set; }

        [JsonProperty("matching")]
        public SWPnscRu6JScESlCbkmLaMatching? Matching { get; set; }

        [JsonProperty("diligence")]
        public SWPnscRu6JScESlCbkmLaDiligence? Diligence { get; set; }

        [JsonProperty("related_data")]
        public TerminalReconciliationOutput? RelatedData { get; set; }

        [JsonProperty("raw_responses")]
        public SWPnscRu6JScESlCbkmLaRawResponses? RawResponses { get; set; }

        [JsonProperty("formatted_responses")]
        public SWPnscRu6JScESlCbkmLaFormattedResponses? FormattedResponses { get; set; }

        [JsonProperty("audit_archive")]
        public object? AuditArchive { get; set; }
    }

    public partial class SWPnscRu6JScESlCbkmLaDiligence
    {
        [JsonProperty("watchlists")]
        public object? Watchlists { get; set; }

        [JsonProperty("fraud")]
        public TentacledFraud? Fraud { get; set; }

        [JsonProperty("financial")]
        public object? Financial { get; set; }

        [JsonProperty("identity_questions")]
        public object? IdentityQuestions { get; set; }

        [JsonProperty("device")]
        public object? Device { get; set; }
    }

    public partial class TentacledFraud
    {
        [JsonProperty("average_score")]
        public double AverageScore { get; set; }

        [JsonProperty("flags")]
        public object[]? Flags { get; set; }

        [JsonProperty("sources")]
        public FluffySources? Sources { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public partial class FluffySources
    {
        [JsonProperty("Iovation")]
        public IdAnalyticsIdScore? Iovation { get; set; }
    }

    public partial class SWPnscRu6JScESlCbkmLaFormattedResponses
    {
        [JsonProperty("Iovation")]
        public FormattedResponsesIovation? Iovation { get; set; }

        [JsonProperty("Identity Element Velocity")]
        public IdentityElementVelocity? IdentityElementVelocity { get; set; }

        [JsonProperty("List")]
        public List? List { get; set; }
    }

    public partial class IdentityElementVelocity
    {
        [JsonProperty("data")]
        public IdentityElementVelocityData? Data { get; set; }
    }

    public partial class IdentityElementVelocityData
    {
        [JsonProperty("decision")]
        public Decision? Decision { get; set; }
    }

    public partial class Decision
    {
        [JsonProperty("entities")]
        public Entities? Entities { get; set; }
    }

    public partial class Entities
    {
        [JsonProperty("ssn")]
        public EmailAddress? Ssn { get; set; }

        [JsonProperty("email_address")]
        public EmailAddress? EmailAddress { get; set; }

        [JsonProperty("phone_number")]
        public EmailAddress? PhoneNumber { get; set; }
    }

    public partial class EmailAddress
    {
        [JsonProperty("30_days")]
        public long The30_Days { get; set; }
    }

    public partial class FormattedResponsesIovation
    {
        [JsonProperty("data")]
        public IovationData? Data { get; set; }
    }

    public partial class IovationData
    {
        [JsonProperty("days_since_device_first_seen_by_alloy")]
        public long DaysSinceDeviceFirstSeenByAlloy { get; set; }

        [JsonProperty("num_times_device_seen_by_alloy")]
        public long NumTimesDeviceSeenByAlloy { get; set; }

        [JsonProperty("3rd_party_os")]
        public bool The3RdPartyOs { get; set; }

        [JsonProperty("latitude_coordinate")]
        public long LatitudeCoordinate { get; set; }

        [JsonProperty("longitude_coordinate")]
        public long LongitudeCoordinate { get; set; }

        [JsonProperty("score_number")]
        public long ScoreNumber { get; set; }

        [JsonProperty("real_ip_country")]
        public string? RealIpCountry { get; set; }

        [JsonProperty("real_ip_country_code")]
        public string? RealIpCountryCode { get; set; }

        [JsonProperty("mobile_system_network_operator_country")]
        public string? MobileSystemNetworkOperatorCountry { get; set; }

        [JsonProperty("mobile_system_carrier_country_code")]
        public string? MobileSystemCarrierCountryCode { get; set; }

        [JsonProperty("devicebbage")]
        public long Devicebbage { get; set; }

        [JsonProperty("realipaddress")]
        public Realipaddress? Realipaddress { get; set; }

        [JsonProperty("realipaddress_loc_region")]
        public string? RealipaddressLocRegion { get; set; }
    }

    public partial class Realipaddress
    {
        [JsonProperty("loc")]
        public Loc? Loc { get; set; }
    }

    public partial class Loc
    {
        [JsonProperty("city")]
        public string? City { get; set; }
    }

    public partial class List
    {
        [JsonProperty("matching")]
        public Dictionary<string, AddressValue>? Matching { get; set; }

        [JsonProperty("data")]
        public TerminalReconciliationOutput? Data { get; set; }
    }

    public partial class SWPnscRu6JScESlCbkmLaMatching
    {
        [JsonProperty("average_score")]
        public long AverageScore { get; set; }
    }

    public partial class SWPnscRu6JScESlCbkmLaRawResponses
    {
        [JsonProperty("Iovation")]
        public IovationElement[]? Iovation { get; set; }

        [JsonProperty("Identity Element Velocity")]
        public IdentityElementVelocity[]? IdentityElementVelocity { get; set; }

        [JsonProperty("List")]
        public object[]?[]? List { get; set; }
    }

    public partial class IovationElement
    {
        [JsonProperty("result")]
        public string? Result { get; set; }

        [JsonProperty("reason")]
        public string? Reason { get; set; }

        [JsonProperty("trackingnumber")]
        public string? Trackingnumber { get; set; }

        [JsonProperty("device.alias")]
        public string? DeviceAlias { get; set; }

        [JsonProperty("device.firstseen")]
        public string? DeviceFirstseen { get; set; }

        [JsonProperty("device.new")]
        public string? DeviceNew { get; set; }

        [JsonProperty("device.bb.age")]
        public string? DeviceBbAge { get; set; }

        [JsonProperty("device.bb.timestamp")]
        public string? DeviceBbTimestamp { get; set; }

        [JsonProperty("device.browser.configuredlang")]
        public string? DeviceBrowserConfiguredlang { get; set; }

        [JsonProperty("device.browser.lang")]
        public string? DeviceBrowserLang { get; set; }

        [JsonProperty("device.browser.type")]
        public string? DeviceBrowserType { get; set; }

        [JsonProperty("device.browser.version")]
        public string? DeviceBrowserVersion { get; set; }

        [JsonProperty("device.cookie.enabled")]
        public string? DeviceCookieEnabled { get; set; }

        [JsonProperty("device.flash.enabled")]
        public string? DeviceFlashEnabled { get; set; }

        [JsonProperty("device.flash.installed")]
        public string? DeviceFlashInstalled { get; set; }

        [JsonProperty("device.flash.version")]
        public string? DeviceFlashVersion { get; set; }

        [JsonProperty("device.js.enabled")]
        public string? DeviceJsEnabled { get; set; }

        [JsonProperty("device.os")]
        public string? DeviceOs { get; set; }

        [JsonProperty("device.screen")]
        public string? DeviceScreen { get; set; }

        [JsonProperty("device.type")]
        public string? DeviceType { get; set; }

        [JsonProperty("device.tz")]
        public string? DeviceTz { get; set; }

        [JsonProperty("ipaddress")]
        public string? Ipaddress { get; set; }

        [JsonProperty("ipaddress.isp")]
        public string? IpaddressIsp { get; set; }

        [JsonProperty("ipaddress.loc.region")]
        public string? IpaddressLocRegion { get; set; }

        [JsonProperty("ipaddress.loc.countrycode")]
        public string? IpaddressLocCountrycode { get; set; }

        [JsonProperty("mobile.app.exeName")]
        public string? MobileAppExeName { get; set; }

        [JsonProperty("mobile.build.device")]
        public string? MobileBuildDevice { get; set; }

        [JsonProperty("mobile.build.product")]
        public string? MobileBuildProduct { get; set; }

        [JsonProperty("mobile.device.brand")]
        public string? MobileDeviceBrand { get; set; }

        [JsonProperty("mobile.device.charging")]
        public string? MobileDeviceCharging { get; set; }

        [JsonProperty("mobile.device.manufacturer")]
        public string? MobileDeviceManufacturer { get; set; }

        [JsonProperty("mobile.device.model")]
        public string? MobileDeviceModel { get; set; }

        [JsonProperty("mobile.location.enabled")]
        public string? MobileLocationEnabled { get; set; }

        [JsonProperty("mobile.location.timezone")]
        public string? MobileLocationTimezone { get; set; }

        [JsonProperty("mobile.system.carrierCountryCode")]
        public string? MobileSystemCarrierCountryCode { get; set; }

        [JsonProperty("mobile.system.jailrootDetected")]
        public string? MobileSystemJailrootDetected { get; set; }

        [JsonProperty("mobile.system.localeCurrency")]
        public string? MobileSystemLocaleCurrency { get; set; }

        [JsonProperty("mobile.system.localeLang")]
        public string? MobileSystemLocaleLang { get; set; }

        [JsonProperty("mobile.system.simulator")]
        public string? MobileSystemSimulator { get; set; }

        [JsonProperty("realipaddress")]
        public string? Realipaddress { get; set; }

        [JsonProperty("realipaddress.source")]
        public string? RealipaddressSource { get; set; }

        [JsonProperty("ruleset.rulesmatched")]
        public string? RulesetRulesmatched { get; set; }

        [JsonProperty("ruleset.score")]
        public string? RulesetScore { get; set; }

        [JsonProperty("mlvalue1")]
        public long Mlvalue1 { get; set; }

        [JsonProperty("registration.check.matchstatus")]
        public string? RegistrationCheckMatchstatus { get; set; }

        [JsonProperty("registration.check.measureofchange")]
        public string? RegistrationCheckMeasureofchange { get; set; }

        [JsonProperty("rules")]
        public Dictionary<string, bool>? Rules { get; set; }

        [JsonProperty("mobile")]
        public Mobile? Mobile { get; set; }
    }

    public partial class Mobile
    {
        [JsonProperty("system")]
        public SystemClass? System { get; set; }
    }

    public partial class SystemClass
    {
        [JsonProperty("carrier")]
        public string? Carrier { get; set; }

        [JsonProperty("networkOperatorName")]
        public string? NetworkOperatorName { get; set; }
    }

    public partial class SWPnscRu6JScESlCbkmLaSummary
    {
        [JsonProperty("result")]
        public string? Result { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("tags")]
        public object[]? Tags { get; set; }

        [JsonProperty("outcome_reasons")]
        public object[]? OutcomeReasons { get; set; }

        [JsonProperty("outcome")]
        public string? Outcome { get; set; }

        [JsonProperty("services")]
        public TentacledServices? Services { get; set; }

        [JsonProperty("alloy_fraud_score")]
        public object? AlloyFraudScore { get; set; }
    }

    public partial class TentacledServices
    {
        [JsonProperty("List")]
        public string? List { get; set; }

        [JsonProperty("Identity Element Velocity")]
        public string? IdentityElementVelocity { get; set; }

        [JsonProperty("Iovation")]
        public string? Iovation { get; set; }
    }

    public partial class EvaluationResult
    {
        [JsonProperty("error")]
        public object? Error { get; set; }

        [JsonProperty("timestamp")]
        public long Timestamp { get; set; }

        [JsonProperty("evaluation_token")]
        public string? EvaluationToken { get; set; }

        [JsonProperty("entity_token")]
        public string? EntityToken { get; set; }

        [JsonProperty("parent_entity_token")]
        public object? ParentEntityToken { get; set; }

        [JsonProperty("group_token")]
        public string? GroupToken { get; set; }

        [JsonProperty("external_entity_id")]
        public string? ExternalEntityId { get; set; }

        [JsonProperty("application_token")]
        public string? ApplicationToken { get; set; }

        [JsonProperty("application_version_id")]
        public long ApplicationVersionId { get; set; }

        [JsonProperty("champion_challenger_id")]
        public object? ChampionChallengerId { get; set; }

        [JsonProperty("summary")]
        public EvaluationResultSummary? Summary { get; set; }

        [JsonProperty("supplied")]
        public Supplied? Supplied { get; set; }

        [JsonProperty("formatted")]
        public Formatted? Formatted { get; set; }

        [JsonProperty("matching")]
        public EvaluationResultMatching? Matching { get; set; }

        [JsonProperty("diligence")]
        public EvaluationResultDiligence? Diligence { get; set; }

        [JsonProperty("related_data")]
        public EvaluationResultRelatedData? RelatedData { get; set; }

        [JsonProperty("raw_responses")]
        public EvaluationResultRawResponses? RawResponses { get; set; }

        [JsonProperty("formatted_responses")]
        public EvaluationResultFormattedResponses? FormattedResponses { get; set; }

        [JsonProperty("audit_archive")]
        public object? AuditArchive { get; set; }
    }

    public partial class EvaluationResultDiligence
    {
        [JsonProperty("watchlists")]
        public PurpleWatchlists? Watchlists { get; set; }

        [JsonProperty("fraud")]
        public StickyFraud? Fraud { get; set; }

        [JsonProperty("financial")]
        public object? Financial { get; set; }

        [JsonProperty("identity_questions")]
        public object? IdentityQuestions { get; set; }

        [JsonProperty("device")]
        public object? Device { get; set; }
    }

    public partial class StickyFraud
    {
        [JsonProperty("average_score")]
        public double AverageScore { get; set; }

        [JsonProperty("flags")]
        public object[]? Flags { get; set; }

        [JsonProperty("sources")]
        public TentacledSources? Sources { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }
    }

    public partial class TentacledSources
    {
        [JsonProperty("Iovation", NullValueHandling = NullValueHandling.Ignore)]
        public IdAnalyticsIdScore? Iovation { get; set; }

        [JsonProperty("ID Analytics ID Score", NullValueHandling = NullValueHandling.Ignore)]
        public IdAnalyticsIdScore? IdAnalyticsIdScore { get; set; }

        [JsonProperty("Ekata", NullValueHandling = NullValueHandling.Ignore)]
        public Ekata? Ekata { get; set; }

        [JsonProperty("Sentilink", NullValueHandling = NullValueHandling.Ignore)]
        public Ekata? Sentilink { get; set; }

        [JsonProperty("Socure 30", NullValueHandling = NullValueHandling.Ignore)]
        public SourcesSocure30? Socure30 { get; set; }
    }

    public partial class EvaluationResultFormattedResponses
    {
        [JsonProperty("Iovation", NullValueHandling = NullValueHandling.Ignore)]
        public FormattedResponsesIovation? Iovation { get; set; }

        [JsonProperty("Identity Element Velocity", NullValueHandling = NullValueHandling.Ignore)]
        public IdentityElementVelocity? IdentityElementVelocity { get; set; }

        [JsonProperty("List", NullValueHandling = NullValueHandling.Ignore)]
        public List? List { get; set; }

        [JsonProperty("NeuroId V2", NullValueHandling = NullValueHandling.Ignore)]
        public FormattedResponsesNeuroIdV2? NeuroIdV2 { get; set; }

        [JsonProperty("ID Analytics ID Score", NullValueHandling = NullValueHandling.Ignore)]
        public FormattedResponsesIdAnalyticsIdScore? IdAnalyticsIdScore { get; set; }

        [JsonProperty("Ekata", NullValueHandling = NullValueHandling.Ignore)]
        public FormattedResponsesEkata? Ekata { get; set; }

        [JsonProperty("Sentilink", NullValueHandling = NullValueHandling.Ignore)]
        public FormattedResponsesSentilink? Sentilink { get; set; }

        [JsonProperty("Socure 30", NullValueHandling = NullValueHandling.Ignore)]
        public FormattedResponsesSocure30? Socure30 { get; set; }

        [JsonProperty("Lexis Nexis Instant ID", NullValueHandling = NullValueHandling.Ignore)]
        public FormattedResponsesLexisNexisInstantId? LexisNexisInstantId { get; set; }

        [JsonProperty("ComplyAdvantage", NullValueHandling = NullValueHandling.Ignore)]
        public FormattedResponsesComplyAdvantage? ComplyAdvantage { get; set; }
    }

    public partial class EvaluationResultMatching
    {
        [JsonProperty("average_score")]
        public double AverageScore { get; set; }

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleAddress? Address { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleAddress? Name { get; set; }

        [JsonProperty("dob", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleAddress? Dob { get; set; }

        [JsonProperty("ssn", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleAddress? Ssn { get; set; }
    }

    public partial class EvaluationResultRawResponses
    {
        [JsonProperty("Iovation", NullValueHandling = NullValueHandling.Ignore)]
        public IovationElement[]? Iovation { get; set; }

        [JsonProperty("Identity Element Velocity", NullValueHandling = NullValueHandling.Ignore)]
        public IdentityElementVelocity[]? IdentityElementVelocity { get; set; }

        [JsonProperty("List", NullValueHandling = NullValueHandling.Ignore)]
        public object[]?[]? List { get; set; }

        [JsonProperty("NeuroId V2", NullValueHandling = NullValueHandling.Ignore)]
        public NeuroIdV2Element[]? NeuroIdV2 { get; set; }

        [JsonProperty("ID Analytics ID Score", NullValueHandling = NullValueHandling.Ignore)]
        public IdAnalyticsIdScoreElement[]? IdAnalyticsIdScore { get; set; }

        [JsonProperty("Ekata", NullValueHandling = NullValueHandling.Ignore)]
        public EkataElement[]? Ekata { get; set; }

        [JsonProperty("Sentilink", NullValueHandling = NullValueHandling.Ignore)]
        public SentilinkElement[]? Sentilink { get; set; }

        [JsonProperty("Socure 30", NullValueHandling = NullValueHandling.Ignore)]
        public Socure30_Element[]? Socure30 { get; set; }

        [JsonProperty("Lexis Nexis Instant ID", NullValueHandling = NullValueHandling.Ignore)]
        public LexisNexisInstantIdElement[]? LexisNexisInstantId { get; set; }

        [JsonProperty("ComplyAdvantage", NullValueHandling = NullValueHandling.Ignore)]
        public ComplyAdvantageElement[]? ComplyAdvantage { get; set; }
    }

    public partial class EvaluationResultRelatedData
    {
        [JsonProperty("social", NullValueHandling = NullValueHandling.Ignore)]
        public SocialElement[]? Social { get; set; }
    }

    public partial class EvaluationResultSummary
    {
        [JsonProperty("result")]
        public string? Result { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("tags")]
        public string?[]? Tags { get; set; }

        [JsonProperty("outcome_reasons")]
        public object[]? OutcomeReasons { get; set; }

        [JsonProperty("outcome")]
        public string? Outcome { get; set; }

        [JsonProperty("services")]
        public StickyServices? Services { get; set; }

        [JsonProperty("alloy_fraud_score")]
        public object? AlloyFraudScore { get; set; }
    }

    public partial class StickyServices
    {
        [JsonProperty("List", NullValueHandling = NullValueHandling.Ignore)]
        public string? List { get; set; }

        [JsonProperty("Identity Element Velocity", NullValueHandling = NullValueHandling.Ignore)]
        public string? IdentityElementVelocity { get; set; }

        [JsonProperty("Iovation", NullValueHandling = NullValueHandling.Ignore)]
        public string? Iovation { get; set; }

        [JsonProperty("NeuroId V2", NullValueHandling = NullValueHandling.Ignore)]
        public string? NeuroIdV2 { get; set; }

        [JsonProperty("ID Analytics ID Score", NullValueHandling = NullValueHandling.Ignore)]
        public string? IdAnalyticsIdScore { get; set; }

        [JsonProperty("Socure 30", NullValueHandling = NullValueHandling.Ignore)]
        public string? Socure30 { get; set; }

        [JsonProperty("Sentilink", NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentilink { get; set; }

        [JsonProperty("Ekata", NullValueHandling = NullValueHandling.Ignore)]
        public string? Ekata { get; set; }

        [JsonProperty("ComplyAdvantage", NullValueHandling = NullValueHandling.Ignore)]
        public string? ComplyAdvantage { get; set; }

        [JsonProperty("Lexis Nexis Instant ID", NullValueHandling = NullValueHandling.Ignore)]
        public string? LexisNexisInstantId { get; set; }
    }

    public partial class EventLinks
    {
        [JsonProperty("evaluation", NullValueHandling = NullValueHandling.Ignore)]
        public Self? Evaluation { get; set; }
    }

    public partial class Self
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }

    public partial class Journey
    {
        [JsonProperty("journey_name")]
        public string? JourneyName { get; set; }

        [JsonProperty("journey_token")]
        public string? JourneyToken { get; set; }

        [JsonProperty("journey_version_num")]
        public string? JourneyVersionNum { get; set; }

        [JsonProperty("_links")]
        public JourneyLinks? Links { get; set; }
    }

    public partial class JourneyLinks
    {
        [JsonProperty("self")]
        public Self? Self { get; set; }

        [JsonProperty("callback_by_entity_application_token")]
        public TerminalReconciliationOutput? CallbackByEntityApplicationToken { get; set; }
    }

    public partial class TemperaturesLinks
    {
        [JsonProperty("self")]
        public Self? Self { get; set; }
    }
}
