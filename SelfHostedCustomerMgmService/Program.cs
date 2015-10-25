using CustomerMgmService.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostedCustomerMgmService
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(CustomerService), new Uri[]
                {
                    new Uri("net.tcp://localhost:8383/CustomerMgmService/")
                }
            );
            ServiceMetadataBehavior mexBehavior = new ServiceMetadataBehavior();
            host.AddServiceEndpoint(typeof(ICustomerMgmService), new NetTcpBinding(SecurityMode.Transport), "CMS");
#if DEBUG
            //don't want to deploy metadata
            host.Description.Behaviors.Add(mexBehavior);
            host.AddServiceEndpoint(typeof(IMetadataExchange), MetadataExchangeBindings.CreateMexTcpBinding(), "mex");
#endif
            foreach (var ba in host.BaseAddresses)
            {
                Console.WriteLine("BaseAddress: \n" + ba);
            }
            foreach (var ep in host.Description.Endpoints)
            {
                Console.WriteLine("\n\nEndpoint: \n- {0}\n- {1}\n- {2}", ep.Address.Uri, ep.Name, ep.Binding.Name);
            }
            host.Open();
            Console.WriteLine("\n\nCustomerMgmService is open");
            Console.ReadKey();
            host.Close();
        }
    }
}