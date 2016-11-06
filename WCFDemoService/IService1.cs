using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFDemoService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/GetMessage/{name}", Method = "GET", 
            BodyStyle = WebMessageBodyStyle.WrappedRequest, 
            ResponseFormat = WebMessageFormat.Json)]
        string GetMessage(string name);
    }
}
