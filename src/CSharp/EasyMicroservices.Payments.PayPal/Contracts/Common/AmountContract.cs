using System.Text.Json.Serialization;

namespace EasyMicroservices.Payments.PayPal.Contracts.Common
{
    internal class AmountContract
    {
        [JsonPropertyName("currency_code")]
        public string CurrencyCode { get; set; }
        [JsonPropertyName("value")]
        public string Value { get; set; }
        [JsonPropertyName("breakdown")]
        public BreakdownContract Breakdown { get; set; }
    }
}
