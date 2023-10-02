using EasyMicroservices.Laboratory.Engine;
using EasyMicroservices.Laboratory.Engine.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyMicroservices.Payments.VirtualServerForTests
{
    public class PaymentsVirtualTestManager
    {
        static Dictionary<int, ResourceManager> InitializedPorts = new Dictionary<int, ResourceManager>();
        public int CurrentPortNumber { get; set; }

        public async Task<bool> OnInitialize(int portNumber)
        {
            CurrentPortNumber = portNumber;
            if (InitializedPorts.ContainsKey(portNumber))
                return false;
            InitializedPorts[portNumber] = new ResourceManager();
            HttpHandler httpHandler = new HttpHandler(InitializedPorts[portNumber]);
            await httpHandler.Start(portNumber);
            return true;
        }

        public void AppendService(int port, string request, string body)
        {
            if (InitializedPorts.TryGetValue(port, out ResourceManager resource))
                resource.Append(request, body);
            else
                throw new KeyNotFoundException(port.ToString());
        }
    }
}
