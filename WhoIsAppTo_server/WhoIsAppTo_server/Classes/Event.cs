using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WhoIsAppTo_server.Classes
{
	public class Event
	{
		public string PrivateKey { get; set; }
		public DateTime EventDate { get; set; }
		public string EventDescription { get; set; }
		public string EventLocation { get; set; }
		public User EventOwner { get; }
		public DateTime LastChanged { get; }
	}
}
