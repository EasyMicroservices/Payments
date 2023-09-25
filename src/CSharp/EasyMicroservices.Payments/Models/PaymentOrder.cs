using EasyMicroservices.Domain.DataTypes;
using System.Collections.Generic;

namespace EasyMicroservices.Payments.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class PaymentOrder
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public CurrencyCodeType CurrencyCode { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<PaymentOrder> PaymentOrders { get; set; }
    }
}
