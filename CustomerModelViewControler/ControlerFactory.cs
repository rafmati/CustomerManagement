using CommonInterface;
using System;

namespace CustomerModelViewControler
{
    public class ControlerFactory
    {
        /// <summary>
        /// <param>Creates a fresh new instance of the specified ITModelViewControler.</param>
        /// <param>throws ArgumentOutOfRangeException</param>
        /// </summary>
        /// <param name="desiredControler_">The enumeration value for the desired available implementation of IModelViewControler</param>
        public ITModelViewControler<ICMUser, ICustomerView> GetControler(AvailableControler desiredControler_)
        {
            switch (desiredControler_)
            {
                case AvailableControler.DBAccess:
                    return new DBBasedControler();

                case AvailableControler.RemoteService:
                    return new ServiceBasedControler();

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}