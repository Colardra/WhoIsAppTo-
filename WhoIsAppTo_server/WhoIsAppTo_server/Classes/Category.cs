using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhoIsAppTo_server.Classes
{
	public class Category
	{
		public string PrivateKey { get; set; }
		public string CategoryDescription { get; set; }
		public string CategoryName { get; set; }
		public ICollection< SubCategory> subCategories { get; set; }

	}
}
