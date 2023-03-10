using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Account_Origination_Demo.API
{
    public class SendSMS
    {
        public SendSMS() { }

         public string ToJointOwner(string phoneNumber, string primaryName)
        {
            // Find your Account SID and Auth Token at twilio.com/console
            // and set the environment variables. See http://twil.io/secure
            const string accountSid = "AC87f0415231e40a2b9dd7917bf5ea1ef4";
            const string authToken = "9d38650a18fc0b85f188fded72dc502b";

            TwilioClient.Init(accountSid, authToken);

            var message = MessageResource.Create(
                body: $"Hello from PSECU! \n\n{primaryName} would like to add you to their account as an additional person. \n\nClick on this link to get started: 'accountoriginationdemo.azurewebsites.net/getstartedjoint' \n\nIf you did not expect this message nor know who this individual is - please ignore this message. ",
                from: new Twilio.Types.PhoneNumber("+18552459202"),
                to: new Twilio.Types.PhoneNumber($"+1{phoneNumber}")
            );

                return "Success";

            }
    }
}

