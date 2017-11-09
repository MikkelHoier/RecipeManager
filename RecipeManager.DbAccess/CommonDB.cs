using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace RecipeManager.DbAccess
{
	public abstract class CommonDB
	{
		#region Fields
		private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=BerthasKøkkenDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		#endregion

		#region Methods
		protected DataSet ExecuteQuery(string query)
		{
			try
			{
				DataSet resultSet = new DataSet();
				using (SqlDataAdapter adapter = new SqlDataAdapter(new SqlCommand(query, new SqlConnection(connectionString))))
				{
					adapter.Fill(resultSet);
				}
				return resultSet;
			}
			catch(Exception)
			{
				throw;
			}
		}
		#endregion
	}	
}
