using EasyMicroservices.Domain.DataTypes;
using EasyMicroservices.Laboratory.Constants;
using EasyMicroservices.Payments.Interfaces;
using EasyMicroservices.Payments.Models;
using EasyMicroservices.Payments.Models.Requests;
using EasyMicroservices.Payments.Models.Responses;
using EasyMicroservices.Payments.VirtualServerForTests;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace EasyMicroservices.Payments.Tests.Providers
{
    public abstract class BasePaymentProviderTest
    {
        public BasePaymentProviderTest(IPaymentProvider paymentProvider)
        {
            PaymentProvider = paymentProvider;
        }

        int Port = 1060;
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

        protected async Task<string> GetLastResponse(int port)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add(RequestTypeHeaderConstants.RequestTypeHeader, RequestTypeHeaderConstants.GiveMeLastFullRequestHeaderValue);
            var httpResponse = await httpClient.GetAsync($"http://localhost:{port}");
            return await httpResponse.Content.ReadAsStringAsync();
        }

        [Theory]
        [InlineData(1000, CurrencyCodeType.USD)]
        public virtual async Task<PaymentOrderResponse> CreateOrderAsync(decimal amount, CurrencyCodeType currencyCode)
        {
            await OnInitialize(Port);
            try
            {
                var response = await PaymentProvider.CreateOrderAsync(new PaymentOrderRequest()
                {
                    Orders = new List<PaymentOrder>()
                {
                     new PaymentOrder()
                     {
                          Amount = amount,
                          CurrencyCode = currencyCode
                     }
                }
                });
                Assert.True(response);
                return response;
            }
            catch (System.Exception)
            {
                var ers = await GetLastResponse(Port);
                throw;
            }
        }
    }
}
