using System;

namespace WcfService1
{
	public class Table
	{
		public string Table_Catalog { get; set; }
		public string Table_Schema { get; set; }
		public string Table_Name { get; set; }
		public string Table_Type { get; set; }

		public override string ToString() {
			return string.Format ("Table_Catalog: {0}, Table_Schema: {1}, Table_Name: {2}, Table_Type: {3}",
			                      Table_Catalog, Table_Schema, Table_Name, Table_Type);
		}
	}
}

