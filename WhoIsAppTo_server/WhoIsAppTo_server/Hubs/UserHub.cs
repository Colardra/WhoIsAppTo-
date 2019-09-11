using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace WhoIsAppTo_server.Hubs
{
	public class UserHub : Hub
	{
		public readonly string DB_HOSTNAME = "DESKTOP-SQ97D7K";
		public readonly string DB_NAME = "whoisappto";
		public readonly string DB_USERNAME = "root";
		public readonly string DB_PASSWORD = "";
		static private SqlConnection SqlConnection;
		public async Task CreateUser(string credentials)
		{

			string connectionString = $"Data Source=" + DB_HOSTNAME + ";Initial Catalog=" + DB_NAME + ";User ID=" + DB_USERNAME + ";Password=" + DB_PASSWORD;
			SqlConnection = new SqlConnection(connectionString);
			SqlConnection.Open();
			SqlDataAdapter adapter = new SqlDataAdapter();
			SqlCommand sqlCommand = new SqlCommand($"INSERT INTO whoisapp.user Values ('" + credentials + "')", SqlConnection);
			sqlCommand.ExecuteNonQuery();
			SqlConnection.Close();
			sqlCommand.Dispose();
			
		}
	}
}
