using EasyMicroservices.Domain.DataTypes;
using EasyMicroservices.Laboratory.Constants;
using EasyMicroservices.Payments.Interfaces;
using EasyMicroservices.Payments.Models;
using EasyMicroservices.Payments.Models.Requests;
using EasyMicroservices.Payments.Models.Responses;
using EasyMicroservices.Payments.VirtualServerForTests;
using System;
using System.Collections.Generic;
using System.Net.Http;
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

        protected async Task<string> GetLastResponse(int port)
        {
            HttpClient httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Add(RequestTypeHeaderConstants.RequestTypeHeader, RequestTypeHeaderConstants.GiveMeLastFullRequestHeaderValue);
            var httpResponse = await httpClient.GetAsync($"http://localhost:{port}");
            return await httpResponse.Content.ReadAsStringAsync();
        }

        protected async Task<T> HandleResponse<T>(Func<Task<T>> task)
        {
            try
            {
                return await task();
            }
            catch (Exception ex)
            {
                try
                {
                    var response = await GetLastResponse(Port);
                    throw new Exception(response, ex);
                }
                catch
                {

                }
                throw;
            }
        }

        [Theory]
        [InlineData(1000, CurrencyCodeType.USD)]
        public virtual async Task<PaymentOrderResponse> CreateOrderAsync(decimal amount, CurrencyCodeType currencyCode)
        {
            await OnInitialize(Port);
            var response = await HandleResponse(() => PaymentProvider.CreateOrderAsync(new PaymentOrderRequest()
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
