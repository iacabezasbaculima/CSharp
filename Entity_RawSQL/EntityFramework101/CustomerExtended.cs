using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework101
{
	public partial class Customer
	{
		public Customer(string id, string companyName, string contactName)
		{
			CustomerID = id;
			CompanyName = companyName;
			ContactName = contactName;
		}
	}
}
