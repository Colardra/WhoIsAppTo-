using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;



namespace WhoIsAppTo_server.Hubs
{
	public class EventHub:Hub
	{
		[HubMethodName("sendUptodateInformation")]
		public static void SendUptodateInformation(string action)
		{
		//	IHubContext context = GlobalHost.ConnectionManager.GetH
		}
	}
}
