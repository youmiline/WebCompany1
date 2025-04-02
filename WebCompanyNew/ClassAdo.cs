using System.Data;
using Microsoft.Data.SqlClient;

namespace WebCompanyNew
{
	public class ClassAdo
	{
		string connectionString;

		public ClassAdo()
		{
			connectionString = "Data Source=LAPTOP-NL88HAUL\\NITRO_SQL_SERVER;Initial Catalog=session;Integrated Security=True;" +
				"Connect Timeout=30;Encrypt=True;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
		}

		public DataSet GetDataSet(string sqlQuery)
		{
			SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
			DataSet ds = new DataSet();
			adapter.Fill(ds,"Table");
			return ds;
		}
	}
}
