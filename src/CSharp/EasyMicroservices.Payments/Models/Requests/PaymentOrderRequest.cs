using System.Collections.Generic;

namespace EasyMicroservices.Payments.Models.Requests
{
    /// <summary>
    /// 
    /// </summary>
    public class PaymentOrderRequest
    {
        /// <summary>
        /// 
        /// </summary>
        public List<PaymentOrder> Orders { get; set; }
    }
}
