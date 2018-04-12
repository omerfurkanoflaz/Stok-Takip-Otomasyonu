using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StokTakipOtomasyonu
{
	public class DBConnection
	{
		public SqlConnection baglanti()
		{
			SqlConnection conn = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=StokTakipOtomasyonu;Integrated Security=True");
			conn.Open();
			return conn;
		}
	}
}
