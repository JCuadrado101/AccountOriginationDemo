using Newtonsoft.Json;
using RestSharp;
using Account_Origination_Demo.Models;

namespace Account_Origination_Demo.API
{
    public class CreateApplicationApi
    {

        public CreateApplicationApi() { }

         public string CreateApplication()
        {
            var options = new RestClientOptions("https://sandbox.alloy.co/v1/")
            {
                MaxTimeout = -1,
            };

            var client = new RestClient(options);
            var request = new RestRequest("journeys/J-7eVTtJUoZja25L2rIEkK/applications?fullData=true", Method.Post);

            request.AddHeader("alloy-journey-application-sync", "true");
            request.AddHeader("Authorization", "Basic eVhOSWlCTmZybXZSaXNab3hUM3p6MGZHWTROdnZkSVo6VnVsZjZpQW9sRTZITmV1eVhZSldFSGhxdkh6aFdLcWE=");
            request.AddHeader("Content-Type", "application/json");

            //var person = new PersonJourneyModel()
            //{
            //    Persons = new List<Person>()
            //    {
            //        new Person()
            //        {
            //            NameFirst = "Jordan",
            //            NameLast = "Cuadrado",
            //            DocumentSsn = "090822929",
            //            AddressLine1 = "1 Innovation Way",
            //            AddressCity = "Harrisburg",
            //            AddressState = "PA",
            //            AddressPostalCode = "17110",
            //            NeuroUserId = "23489sdf-a942tj8ef-asofwe",
            //            SiteId = "28dfa9342",
            //            ExternalEntityId = "08cc896e-4320-43c3-b5b0-af8e9bc9e5cb"
            //        }

            //    }
            //};


            //var body = JsonConvert.SerializeObject(person);
            var body = @"{" + "\n" +
                 @"    ""persons"": [" + "\n" +
                 @"        {" + "\n" +
                 @"            ""name_first"": ""firstName""," + "\n" +
                 @"            ""name_last"": ""lastName""," + "\n" +
                 @"            ""document_ssn"": ""047356810""," + "\n" +
                 @"            ""birth_date"": ""1991-01-10""," + "\n" +
                 @"            ""address_line_1"": ""2004 Rock Fall""," + "\n" +
                 @"            ""address_city"": ""Harrisburg""," + "\n" +
                 @"            ""address_state"": ""PA""," + "\n" +
                 @"            ""address_postal_code"": ""17110""," + "\n" +
                 @"            ""address_country_code"": ""US""," + "\n" +
                 @"            ""neuro_user_id"" : ""23489sdf-a942tj8ef-asofwe""," + "\n" +
                 @"            ""site_id"" : ""28dfa9342""," + "\n" +
                 @"            ""identifiers"": {" + "\n" +
                 @"                ""external_entity_id"": ""400a6a19-e8ea-4adf-a1c0-64f9b5be58f0""" + "\n" +
                 @"            }" + "\n" +
                 @"        }" + "\n" +
                 @"    ]" + "\n" +
                 @"}";

            request.AddStringBody(body, DataFormat.Json);
            RestResponse response = client.Execute(request);
            var json = JsonConvert.DeserializeObject<Temperatures>(response.Content!);

            Console.WriteLine(body);

            return json!.JourneyApplicationStatus!;

        }
    }
}

