using System;
using System.Collections.Generic;
using System.Linq;

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
        /// <summary>
        /// 
        /// </summary>
        public List<PaymentUrl> Urls { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetSuccessUrl()
        {
            Urls.ThrowIfNullOrEmpty();
            var findSuccessUrl = Urls.FirstOrDefault(x => x.Type == DataTypes.RequestUrlType.SuccessUrl);
            return findSuccessUrl?.Url;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetCancelUrl()
        {
            Urls.ThrowIfNullOrEmpty();
            var findCancelUrl = Urls.FirstOrDefault(x => x.Type == DataTypes.RequestUrlType.CancelUrl);
            return findCancelUrl?.Url;
        }
    }
}
