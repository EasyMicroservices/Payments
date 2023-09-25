using EasyMicroservices.Payments.PayPal.Contracts.Common;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EasyMicroservices.Payments.PayPal.Contracts.Responses
{
    internal class OrderResponseContract
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }
        [JsonPropertyName("intent")]
        public string Intent { get; set; }
        [JsonPropertyName("status")]
        public string Status { get; set; }
        [JsonPropertyName("purchase_units")]
        public List<PurchaseUnitsResponseContract> PurchaseUnits { get; set; }
        [JsonPropertyName("create_time")]
        public DateTime CreateTime { get; set; }
        [JsonPropertyName("links")]
        public List<LinkContract> Links { get; set; }
    }
}
