using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Reflection;
using System.Data.SqlClient;
using Dapper;

namespace WcfService1
{
	public class Service1 : IService1
    {
		public M5Response<T> MakeResponse<T>() {
			var connectionString = "Server=eaa82709-81ce-49fd-87b6-a3b200e7b23b.sqlserver.sequelizer.com;Database=dbeaa8270981ce49fd87b6a3b200e7b23b;User ID=fdealsakpmsqlslo;Password=XRibr8JuHf8nkZ7af3C2ewEYys5DhkmzUszM2uGoGWztRUoSFSFGoGCAmsK8cfnw;";

			M5Response<T> response = new M5Response<T> ();

			using (var connection = new SqlConnection (connectionString)) {
				connection.Open ();
				response.rows = connection.Query<T> ("SELECT * FROM information_schema.tables");
			}

			return response;
		}

		public object Which (string entity, string id)
		{
			var entityType = Type.GetType ("WcfService1." + entity);
			Type myClass = typeof(Service1);

			MethodInfo mi = myClass.GetMethod ("MakeResponse");
			MethodInfo miConstructed = mi.MakeGenericMethod (entityType);
			object[] args = {};
			return miConstructed.Invoke(this, args);
		}
    }
}
