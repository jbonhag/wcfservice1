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
		object Which (string entity, string id);
    }
}
