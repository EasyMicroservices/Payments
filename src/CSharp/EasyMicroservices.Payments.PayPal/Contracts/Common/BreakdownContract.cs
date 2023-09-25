using System.Text.Json.Serialization;

namespace EasyMicroservices.Payments.PayPal.Contracts.Common
{
    internal class BreakdownContract
    {
        [JsonPropertyName("item_total")]
        public AmountContract TotalAmount { get; set; }
    }
}
