using EasyMicroservices.Laboratory.Engine;
using EasyMicroservices.Laboratory.Engine.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EasyMicroservices.Payments.VirtualServerForTests
{
    public class PaymentsVirtualTestManager
    {
        static HashSet<int> InitializedPorts = new HashSet<int>();
        static readonly ResourceManager ResourceManager = new ResourceManager();
        public int CurrentPortNumber { get; set; }

        public async Task<bool> OnInitialize(int portNumber)
        {
            CurrentPortNumber = portNumber;
            if (InitializedPorts.Contains(portNumber))
                return false;
            InitializedPorts.Add(portNumber);
            HttpHandler httpHandler = new HttpHandler(ResourceManager);
            await httpHandler.Start(portNumber);
            return true;
        }

        public void AppendService(int port, string request, string body)
        {
            ResourceManager.Append(request, body);
        }
    }
}
