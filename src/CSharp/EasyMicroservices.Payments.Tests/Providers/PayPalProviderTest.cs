using EasyMicroservices.Payments.PayPal.Providers;
using EasyMicroservices.Payments.VirtualServerForTests.TestResources;

namespace EasyMicroservices.Payments.Tests.Providers
{
    public class PayPalProviderTest : BasePaymentProviderTest
    {
        public PayPalProviderTest() : base(1060, new PayPalProvider("http://localhost:1060"))
        {
        }

        protected override void AppendServices()
        {
            foreach (var item in PayPalTestResource.GetResources())
            {
                AppendService(item.Key, item.Value);
            }
        }
    }
}
