using EasyMicroservices.Payments.DataTypes;
using System;
using System.Collections.Generic;
using System.Text;

namespace EasyMicroservices.Payments.Models.Responses
{
    /// <summary>
    /// 
    /// </summary>
    public class RetrieveOrderResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public PaymentStatusType Status { get; set; }
    }
}
