using EasyMicroservices.Payments.DataTypes;
using EasyMicroservices.Payments.Models.Requests;
using EasyMicroservices.Payments.Models.Responses;
using EasyMicroservices.Payments.PayPal.Contracts.Requests;
using EasyMicroservices.Payments.PayPal.Contracts.Responses;
using EasyMicroservices.Payments.Providers;
using EasyMicroservices.ServiceContracts;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace EasyMicroservices.Payments.PayPal.Providers
{
    /// <summary>
    /// 
    /// </summary>
    public class PayPalProvider : BasePaymentsProvider
    {
        /// <summary>
        /// 
        /// </summary>
        public override PaymentServiceType ServiceType { get; } = PaymentServiceType.PayPal;
        string BaseUrl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="baseUrl"></param>
        public PayPalProvider(string baseUrl)
        {
            BaseUrl = baseUrl;
        }
        /// <summary>
        /// 
        /// </summary>
        public static HttpClient HttpClient = new HttpClient();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="paymentOrderRequest"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public override async Task<MessageContract<PaymentOrderResponse>> CreateOrderAsync(PaymentOrderRequest paymentOrderRequest, CancellationToken cancellationToken = default)
        {
            Dictionary<string, string> configurationMap = new Dictionary<string, string>
            {
                { "clientId", "fdbdbjkndfbkfdbjdfnbu" },
                { "clientSecret", "dfdfbdfbdfbdfbdfbffdbrther" },
                { "mode", "live" },
            };
            var content = new StringContent(System.Text.Json.JsonSerializer.Serialize(new OrderRequestContract()
            {
                ApplicationContext = new Contracts.Common.ApplicationContextContract()
                {
                    CancelUrl = null,
                    ReturnUrl = null,
                },
                Units = paymentOrderRequest.Orders.Select(x => new Contracts.Common.PurchaseUnitContract()
                {
                    Amount = new Contracts.Common.AmountContract()
                    {
                        Value = x.Amount.ToString(),
                        CurrencyCode = x.CurrencyCode.ToString()
                    }
                }).ToList(),
                Intent = "CAPTURE"
            }), Encoding.UTF8, "application/json");
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            var response = await HttpClient.PostAsync($"{BaseUrl}/v2/checkout/orders", content);

            var responseString = System.Text.Json.JsonSerializer.Deserialize<OrderResponseContract>(await response.Content.ReadAsStringAsync());
            return new PaymentOrderResponse()
            {
                Urls = responseString.Links.Select(x => new Models.PaymentUrl()
                {
                    Url = x.Href
                }).ToList()
            };
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="retrieveOrderRequest"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public override Task<MessageContract<RetrieveOrderResponse>> RetrieveOrderAsync(RetrieveOrderRequest retrieveOrderRequest, CancellationToken cancellationToken = default)
        {
            throw new System.NotImplementedException();
        }
    }
}
