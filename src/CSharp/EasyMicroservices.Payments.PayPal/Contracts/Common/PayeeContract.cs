using System.Text.Json.Serialization;

namespace EasyMicroservices.Payments.PayPal.Contracts.Common
{
    internal class PayeeContract
    {
        [JsonPropertyName("email_address")]
        public string EmailAddress { get; set; }
        [JsonPropertyName("merchant_id")]
        public string MerchantId { get; set; }
    }
}
