using EasyMicroservices.Payments.DataTypes;
using EasyMicroservices.Payments.Interfaces;
using EasyMicroservices.Payments.Models.Requests;
using EasyMicroservices.Payments.Models.Responses;
using EasyMicroservices.ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public abstract Task<MessageContract<PaymentOrderResponse>> CreateOrderAsync(PaymentOrderRequest paymentOrderRequest, CancellationToken cancellationToken = default);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="retrieveOrderRequest"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public abstract Task<MessageContract<RetrieveOrderResponse>> RetrieveOrderAsync(RetrieveOrderRequest retrieveOrderRequest, CancellationToken cancellationToken = default);

        /// <summary>
        /// 
        /// </summary>
        public abstract PaymentServiceType ServiceType { get; }
    }
}
