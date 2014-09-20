using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        [WebInvoke(Method = "GET",
                    ResponseFormat = WebMessageFormat.Json)]
        string GetData(int value);

		[OperationContract]
		[WebInvoke(Method = "GET",
			ResponseFormat = WebMessageFormat.Json)]
		string SayHello(string name);

		[OperationContractAttribute]
		[WebInvoke(Method = "GET",
			ResponseFormat = WebMessageFormat.Json)]
		Album Albums (int id);
    }
}
