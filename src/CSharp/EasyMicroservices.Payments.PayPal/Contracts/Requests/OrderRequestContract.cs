using EasyMicroservices.Payments.PayPal.Contracts.Common;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EasyMicroservices.Payments.PayPal.Contracts.Requests
{
    internal class OrderRequestContract
    {
        [JsonPropertyName("intent")]
        public string Intent { get; set; }
        [JsonPropertyName("purchase_units")]
        public List<PurchaseUnitContract> Units { get; set; }
        [JsonPropertyName("application_context")]
        public ApplicationContextContract ApplicationContext { get; set; }
    }
}
