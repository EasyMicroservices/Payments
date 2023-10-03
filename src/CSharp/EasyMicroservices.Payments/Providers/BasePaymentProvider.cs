using EasyMicroservices.Payments.DataTypes;
using EasyMicroservices.Payments.Interfaces;
using EasyMicroservices.Payments.Models.Requests;
using EasyMicroservices.Payments.Models.Responses;
using EasyMicroservices.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyMicroservices.Payments.Providers
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BasePaymentsProvider : IPaymentProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paymentOrderRequest"></param>
        /// <returns></returns>
        public abstract Task<MessageContract<PaymentOrderResponse>> CreateOrderAsync(PaymentOrderRequest paymentOrderRequest);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="retrieveOrderRequest"></param>
        /// <returns></returns>
        public abstract Task<MessageContract<RetrieveOrderResponse>> RetrieveOrderAsync(RetrieveOrderRequest retrieveOrderRequest);

        /// <summary>
        /// 
        /// </summary>
        public abstract PaymentServiceType ServiceType { get; }
    }
}
