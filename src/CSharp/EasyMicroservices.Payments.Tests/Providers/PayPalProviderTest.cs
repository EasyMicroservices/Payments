using EasyMicroservices.Payments.PayPal.Providers;

namespace EasyMicroservices.Payments.Tests.Providers
{
    public class PayPalProviderTest : BasePaymentProviderTest
    {
        public PayPalProviderTest() : base(1060, new PayPalProvider("http://localhost:1060"))
        {
        }

        protected override void AppendServices()
        {

            AppendService($@"POST /v2/checkout/orders HTTP/1.1
*RequestSkipBody*
",

$@"HTTP/1.1 200 OK
Content-Type: application/json; charset=utf-8
Server: Kestrel
X-Powered-By: ASP.NET
Date: Thu, 30 Apr 2023 05:05:43 GMT
Content-Length: 0

{{
    ""id"": ""09H88704RC448263N"",
    ""intent"": ""CAPTURE"",
    ""status"": ""CREATED"",
    ""purchase_units"": [
        {{
            ""reference_id"": ""default"",
            ""amount"": {{
                ""currency_code"": ""USD"",
                ""value"": ""100.00""
            }},
            ""payee"": {{
                ""email_address"": ""etondoze-facilitator@gmail.com"",
                ""merchant_id"": ""ER87FV8ER63HJ""
            }}
        }}
    ],
    ""create_time"": ""2022-02-04T02:22:17Z"",
    ""links"": [
        {{
            ""href"": ""https://api.sandbox.paypal.com/v2/checkout/orders/09H88704RC448263N"",
            ""rel"": ""self"",
            ""method"": ""GET""
        }},
        {{
            ""href"": ""https://www.sandbox.paypal.com/checkoutnow?token=09H88704RC448263N"",
            ""rel"": ""approve"",
            ""method"": ""GET""
        }},
        {{
            ""href"": ""https://api.sandbox.paypal.com/v2/checkout/orders/09H88704RC448263N"",
            ""rel"": ""update"",
            ""method"": ""PATCH""
        }},
        {{
            ""href"": ""https://api.sandbox.paypal.com/v2/checkout/orders/09H88704RC448263N/capture"",
            ""rel"": ""capture"",
            ""method"": ""POST""
        }}
    ]
}}");
        }
    }
}
