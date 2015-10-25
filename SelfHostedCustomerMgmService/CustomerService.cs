using CustomerMgmService.Contracts;
using CustomerMgmService.Contracts.Messages;
using CustomerModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace SelfHostedCustomerMgmService
{
    class CustomerService : ICustomerMgmService
    {
        public List<CustomerData> GetCustomers()
        {
            List<CustomerData> returnValue = null;
            try
            {
                using (var db = new CustomerManagementEntities())
                {
                    var customerList = from customer in db.usp_AllCustomers()
                                       select new CustomerData(customer.ID, customer.PersonalNum, customer.Name, customer.LastName,
                                           customer.TotalDebt, customer.Note);
                    returnValue = new List<CustomerData>(customerList);
                };
            }
            catch (Exception)
            {
                //todo: logging
            }
            return returnValue;
        }

        public bool UserLogin(string userName_, string userPassword_)
        {
            bool successful = true;
            ObjectParameter pResult = new ObjectParameter("pResult", -1);
            try
            {
                using (var db = new CustomerManagementEntities())
                {
                    db.usp_CMLogin(userName_, userPassword_, pResult);
                }
            }
            catch (Exception)
            {
                //todo: logging
                successful = false;
            }
            return successful && (int)pResult.Value == 1;
        }

        public bool Add(CustomerData data_)
        {
            bool successful = true;
            try
            {
                using (var db = new CustomerManagementEntities())
                {
                    successful = db.usp_AddCustomer(data_.PersonalNum, data_.Name, data_.LastName, data_.TotalDebt, data_.Note) == 1;
                }
            }
            catch (Exception)
            {
                //todo: logging
                successful = false;
            }
            return successful;
        }

        public bool Update(CustomerData data_)
        {
            bool successful = true;
            try
            {
                using (var db = new CustomerManagementEntities())
                {
                    successful = db.usp_UpdateCustomer(data_.ID, data_.PersonalNum, data_.Name, data_.LastName, data_.TotalDebt, data_.Note) == 1;
                }
            }
            catch (Exception)
            {
                //todo: logging
                successful = false;
            }
            return successful;
        }
    }
}