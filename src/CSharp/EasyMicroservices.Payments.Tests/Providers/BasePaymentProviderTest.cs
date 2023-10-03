using EasyMicroservices.Domain.DataTypes;
using EasyMicroservices.Payments.Interfaces;
using EasyMicroservices.Payments.Models;
using EasyMicroservices.Payments.Models.Requests;
using EasyMicroservices.Payments.Models.Responses;
using EasyMicroservices.Payments.VirtualServerForTests;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace EasyMicroservices.Payments.Tests.Providers
{
    public abstract class BasePaymentProviderTest
    {
        public BasePaymentProviderTest(int port, IPaymentProvider paymentProvider)
        {
            PaymentProvider = paymentProvider;
            Port = port;
        }

        int Port = 0;
        IPaymentProvider PaymentProvider { get; set; }

        protected static PaymentsVirtualTestManager PaymentsVirtualTestManager { get; set; } = new PaymentsVirtualTestManager();

        async Task OnInitialize(int portNumber)
        {
            if (await PaymentsVirtualTestManager.OnInitialize(portNumber))
            {
                AppendServices();
            }
        }

        protected abstract void AppendServices();

        protected void AppendService(string request, string response)
        {
            PaymentsVirtualTestManager.AppendService(Port, request, response);
        }

        [Theory]
        [InlineData(1000, CurrencyCodeType.USD)]
        public virtual async Task<PaymentOrderResponse> CreateOrderAsync(decimal amount, CurrencyCodeType currencyCode)
        {
            await OnInitialize(Port);
            var response = await PaymentsVirtualTestManager.HandleResponse(Port, () => PaymentProvider.CreateOrderAsync(new PaymentOrderRequest()
            {
                Orders = new List<PaymentOrder>()
                {
                     new PaymentOrder()
                     {
                          Name = "Test Example product",
                          Amount = amount,
                          CurrencyCode = currencyCode
                     }
                },
                Urls = new List<PaymentUrl>()
                {
                     new PaymentUrl()
                     {
                          Type = DataTypes.RequestUrlType.SuccessUrl,
                          Url = $"http://localhost:{Port}/successurl"
                     }
                }
            }));
            Assert.True(response);
            return response;
        }
    }
}
