using System;
using System.Collections.Generic;

namespace WcfService1
{
	public class M5Response<T>
	{
		public string message { get; set; }
		public IEnumerable<T> rows { get; set; }

		public M5Response()
		{
			rows = new List<T> ();
		}
	}
}

