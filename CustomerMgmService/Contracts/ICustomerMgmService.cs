using CustomerMgmService.Contracts.Messages;
using System.Collections.Generic;
using System.ServiceModel;

namespace CustomerMgmService.Contracts
{
    [ServiceContract(SessionMode = SessionMode.Allowed)]
    public interface ICustomerMgmService
    {
        [OperationContract]
        bool Add(CustomerData data_);

        [OperationContract]
        bool Update(CustomerData data_);

        [OperationContract]
        bool UserLogin(string userName_, string userPassword_);

        [OperationContract]
        List<CustomerData> GetCustomers();
    }
}