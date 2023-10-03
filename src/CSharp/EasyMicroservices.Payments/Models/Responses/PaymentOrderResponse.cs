using System.Collections.Generic;

namespace EasyMicroservices.Payments.Models.Responses
{
    /// <summary>
    /// 
    /// </summary>
    public class PaymentOrderResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<PaymentUrl> Urls { get; set; }
    }
}