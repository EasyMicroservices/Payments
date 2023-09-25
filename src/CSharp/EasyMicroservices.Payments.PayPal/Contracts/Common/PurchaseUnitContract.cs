using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EasyMicroservices.Payments.PayPal.Contracts.Common
{
    internal class PurchaseUnitContract
    {
        [JsonPropertyName("items")]
        internal List<OrderItemContract> Items { get; set; }
        [JsonPropertyName("amount")]
        internal AmountContract Amount { get; set; }
    }
}
