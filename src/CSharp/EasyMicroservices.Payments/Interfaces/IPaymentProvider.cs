using EasyMicroservices.Payments.DataTypes;
using EasyMicroservices.Payments.Models.Requests;
using EasyMicroservices.Payments.Models.Responses;
using EasyMicroservices.ServiceContracts;
using System.Threading.Tasks;

namespace EasyMicroservices.Payments.Interfaces
{
    /// <summary>
    /// 
    /// </summary>
    public interface IPaymentProvider
    {
        /// <summary>
        /// 
        /// </summary>
        public PaymentServiceType ServiceType { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paymentOrderRequest"></param>
        /// <returns></returns>
        Task<MessageContract<PaymentOrderResponse>> CreateOrderAsync(PaymentOrderRequest paymentOrderRequest);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="retrieveOrderRequest"></param>
        /// <returns></returns>
        Task<MessageContract<RetrieveOrderResponse>> RetrieveOrderAsync(RetrieveOrderRequest  retrieveOrderRequest);
    }
}
