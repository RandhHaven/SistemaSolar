using EntitySistemaSolar.Helpers;
using SistemaSolarBussinesCore;
using System;
using System.Web.Services;

namespace WsSistemaSolar
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceSistemaSolar" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceSistemaSolar.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class ServiceSistemaSolar : IServiceSistemaSolar
    {

        [WebMethod]
        public string GetData(int value)
        {
            // return string.Format("You entered: {0}", value);
            return SerializationHelper.SerializeToXmlString(new SistemaSolarCore());
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
