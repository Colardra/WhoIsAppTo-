using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhoIsAppTo_server.Classes
{
	public class User
	{
		public string PrivateKey { get; set; }
		public string Credentials { get; set; }
		public string Bio { get; set; }
		public bool Connected { get; }
		public ICollection<Event> Events { get; set; }
		public ICollection<Category> Preferencies { get; set; }

	}
}
