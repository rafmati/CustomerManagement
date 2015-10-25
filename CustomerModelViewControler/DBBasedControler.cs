using CommonInterface;
using CustomerModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace CustomerModelViewControler
{
    internal sealed class DBBasedControler : TModelViewControler<ICMUser, ICustomerView>
    {
        private static Func<ICMUser, bool> LoginDelegate = new Func<ICMUser, bool>(Login);
        private static Func<ICustomerView, bool> SaveDelegate = new Func<ICustomerView, bool>(SaveCustomer);
        private static Func<ICustomerView, bool> UpdateDelegate = new Func<ICustomerView, bool>(UpdateCustomer);
        private static Func<List<ICustomerView>> LoadDelegate = new Func<List<ICustomerView>>(LoadCustomers);

        public DBBasedControler()
            : base(LoginDelegate, SaveDelegate, UpdateDelegate, LoadDelegate)
        {
        }

        private static bool Login(ICMUser userDetails_)
        {
            bool successful = true;
            ObjectParameter pResult = new ObjectParameter("pResult", -1);
            try
            {
                using (var db = new CustomerManagementEntities())
                {
                    db.usp_CMLogin(userDetails_.UserName, userDetails_.UserPassword, pResult);
                }
            }
            catch (Exception)
            {
                //todo: logging
                successful = false;
            }
            return successful && (int)pResult.Value == 1;
        }

        private static bool SaveCustomer(ICustomerView cv_)
        {
            bool successful = true;
            try
            {
                using (var db = new CustomerManagementEntities())
                {
                    successful = db.usp_AddCustomer(cv_.PersonalNum, cv_.Name, cv_.LastName, cv_.TotalDebt, cv_.Note) == 1;
                }
            }
            catch (Exception)
            {
                //todo: logging
                successful = false;
            }
            return successful;
        }

        private static bool UpdateCustomer(ICustomerView cv_)
        {
            bool successful = true;
            try
            {
                using (var db = new CustomerManagementEntities())
                {
                    successful = db.usp_UpdateCustomer(cv_.ID, cv_.PersonalNum, cv_.Name, cv_.LastName, cv_.TotalDebt, cv_.Note) == 1;
                }
            }
            catch (Exception)
            {
                //todo: logging
                successful = false;
            }
            return successful;
        }

        private static List<ICustomerView> LoadCustomers()
        {
            List<ICustomerView> returnValue = null;
            try
            {
                using (var db = new CustomerManagementEntities())
                {
                    var customerList = from customer in db.usp_AllCustomers()
                                       select new CustomerView(customer.ID, customer.PersonalNum, customer.Name, customer.LastName,
                                           customer.TotalDebt, customer.Note);
                    returnValue = new List<ICustomerView>(customerList);
                };
            }
            catch (Exception)
            {
                //todo: logging
            }
            return returnValue;
        }
    }
}