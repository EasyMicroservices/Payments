using System.Text.Json.Serialization;

namespace EasyMicroservices.Payments.PayPal.Contracts.Common
{
    internal class ApplicationContextContract
    {
        [JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }
        [JsonPropertyName("cancel_url")]
        public string CancelUrl { get; set; }
    }
}
