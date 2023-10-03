using EasyMicroservices.Payments.Stripe.Providers;
using EasyMicroservices.Payments.VirtualServerForTests.TestResources;
using Stripe;

namespace EasyMicroservices.Payments.Tests.Providers
{
    public class StripeProviderTest : BasePaymentProviderTest
    {
        public StripeProviderTest() : base(1061, new StripeProvider(GetStripeClient()))
        {
        }

        static IStripeClient GetStripeClient()
        {
            return new StripeClient("apikeytest", "clientIdTest", null, $"http://localhost:{1061}");
        }

        protected override void AppendServices()
        {
            foreach (var item in StripeTestResource.GetResources())
            {
                AppendService(item.Key, item.Value);
            }
        }
    }
}
