using EasyMicroservices.Payments.PayPal.Contracts.Common;
using System.Text.Json.Serialization;

namespace EasyMicroservices.Payments.PayPal.Contracts.Responses
{
    internal class PurchaseUnitsResponseContract
    {
        [JsonPropertyName("reference_id")]
        public string ReferenceId { get; set; }
        [JsonPropertyName("amount")]
        public AmountContract Amount { get; set; }
        [JsonPropertyName("payee")]
        public PayeeContract Payee { get; set; }
    }
}
