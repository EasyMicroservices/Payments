using System.Text.Json.Serialization;

namespace EasyMicroservices.Payments.PayPal.Contracts.Common
{
    internal class LinkContract
    {
        [JsonPropertyName("href")]
        public string Href { get; set; }
        [JsonPropertyName("rel")]
        public string Rel { get; set; }
        [JsonPropertyName("method")]
        public string Method { get; set; }
    }
}
