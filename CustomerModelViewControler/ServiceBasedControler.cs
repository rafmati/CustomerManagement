using CommonInterface;
using CustomerModelViewControler.CustomerMgmService;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace CustomerModelViewControler
{
    internal sealed class ServiceBasedControler : TModelViewControler<ICMUser, ICustomerView>
    {
        #region DataAdapter functions

        /// <summary>
        /// Simple data adapter function
        /// </summary>
        private static CustomerData CustomerViewToCustomerData(ICustomerView cv_)
        {
            return new CustomerData()
            {
                ID = cv_.ID,
                PersonalNum = cv_.PersonalNum,
                Name = cv_.Name,
                LastName = cv_.LastName,
                TotalDebt = cv_.TotalDebt,
                Note = cv_.Note
            };
        }

        /// <summary>
        /// Simple data adapter function
        /// </summary>
        private static CustomerView CustomerDataToCustomerView(CustomerData cd_)
        {
            return new CustomerView(cd_.ID, cd_.PersonalNum, cd_.Name, cd_.LastName, cd_.TotalDebt, cd_.Note);
        }
        #endregion

        #region WCF Client proxy helpers

        private static CustomerMgmServiceClient GetClient()
        {
            var client = new CustomerMgmServiceClient();
            client.Open();
            return client;
        }

        private static void CloseClient(CustomerMgmServiceClient client_)
        {
            try
            {
                client_.Close();
            }
            catch (CommunicationException e)
            {
                //todo: logging
                client_.Abort();
            }
            catch (TimeoutException e)
            {
                //todo: logging
                client_.Abort();
            }
            catch (Exception e)
            {
                //todo: logging
                client_.Abort();
                throw;
            }
        }
        #endregion

        private static Func<ICMUser, bool> LoginDelegate = new Func<ICMUser, bool>(Login);
        private static Func<ICustomerView, bool> SaveDelegate = new Func<ICustomerView, bool>(SaveCustomer);
        private static Func<ICustomerView, bool> UpdateDelegate = new Func<ICustomerView, bool>(UpdateCustomer);
        private static Func<List<ICustomerView>> LoadDelegate = new Func<List<ICustomerView>>(LoadCustomers);

        public ServiceBasedControler()
            : base(LoginDelegate, SaveDelegate, UpdateDelegate, LoadDelegate)
        {
        }

        private static bool Login(ICMUser userDetails_)
        {
            var client = GetClient();
            bool returnValue = client.UserLogin(userDetails_.UserName, userDetails_.UserPassword);
            CloseClient(client);
            return returnValue;
        }

        private static bool SaveCustomer(ICustomerView cv_)
        {
            var client = GetClient();
            bool returnValue = client.Add(ServiceBasedControler.CustomerViewToCustomerData(cv_));
            CloseClient(client);
            return returnValue;
        }

        private static bool UpdateCustomer(ICustomerView cv_)
        {
            var client = GetClient();
            bool returnValue = client.Update(ServiceBasedControler.CustomerViewToCustomerData(cv_));
            CloseClient(client);
            return returnValue;
        }

        private static List<ICustomerView> LoadCustomers()
        {
            var client = GetClient();
            var customers = client.GetCustomers();
            List<ICustomerView> returnValue = new List<ICustomerView>(customers.Length);
            foreach (var customer in customers)
            {
                returnValue.Add(ServiceBasedControler.CustomerDataToCustomerView(customer));
            }
            CloseClient(client);
            return returnValue;
        }
    }
}