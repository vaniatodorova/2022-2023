using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Console_database
{
	class Program
	{
		static void Main(string[] args)
		{
			SqlConnection con;
			string str;
			string name;
			int age;
			try
			{
				str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\11a\Repos\softdev\SoftDev\Console_database\Datas.mdf;Integrated Security=True";
				con = new SqlConnection(str);
				con.Open();
				Console.WriteLine("Datavase connected");
				Console.WriteLine("\n Enter Your Name :");
				name = Console.ReadLine();
				Console.WriteLine("\n Enter Your Age :");
				age = int.Parse(Console.ReadLine());
				string query = "INSERT INTO details (user_name, user_age) VALUES('" + name + "'," + age + ")";
				SqlCommand ins = new SqlCommand(query, con);
				ins.ExecuteNonQuery();
				Console.WriteLine("\n Data Stored Into Database");
				string q = "SELECT * FROM details";
				SqlCommand view = new SqlCommand(q, con);
				SqlDataReader dr = view.ExecuteReader();
				while (dr.Read())
				{
					Console.WriteLine("\nName :" + dr.GetValue(1).ToString());
					Console.WriteLine("\nAge :" + dr.GetValue(2).ToString());
				}
				con.Close();
			}
			catch(SqlException x)
			{
				Console.WriteLine(x.Message);
			}
		}
	}
}
