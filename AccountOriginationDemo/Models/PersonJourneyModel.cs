namespace Account_Origination_Demo.Models
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;

    public partial class PersonJourneyModel
    {
        [JsonProperty("persons")]
        public List<Person>? Persons { get; set; }
    }

    public partial class Person
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

        [JsonProperty("identifiers: {external_entity_id}")]
        public string? ExternalEntityId { get; set; }
    }

    //public partial class IdentifiersEntity
    //{
    //    [JsonProperty("identifiers: {external_entity_id}")]
    //    public string? ExternalEntityId { get; set; }
    //}
}
