using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Minions
{
	class Program
	{
		static void Main(string[] args)
		{
			SqlConnection con;
			string str;
			try
			{
				str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\11a\Repos\SoftDev\SoftDev\Minions\MinionsDB.mdf;Integrated Security=True";
				con = new SqlConnection(str);
				con.Open();
				int villainId = int.Parse(Console.ReadLine());
				string query = "SELECT v.Name, mv.MinionId, m.Age, m.Name as minionName " +
								"FROM Villains AS v " +
								"JOIN MinionsVillains AS mv ON mv.villainId=v.Id " +
								"JOIN Minions AS m ON m.Id=mv.MinionId " +
								"WHERE mv.VillainId = " + villainId+
								" ORDER BY minionName ASC";

				SqlCommand cmd = new SqlCommand(query, con);
				SqlDataReader reader = cmd.ExecuteReader();
				if (villainId <= 5)
				{
					using (reader)
					{
						int cnt = 0;
						while (reader.Read())
						{
							if (cnt == 0)
							{
								string evilName = (string)reader["Name"];
								Console.WriteLine("Villain: {0}", evilName);
							}
							cnt++;
							int minionId = (int)reader["MinionId"];
							int age = (int)reader["Age"];
							string minionName = (string)reader["minionName"];
							//int VillainId = a;

							Console.WriteLine("{0}. {1} {2}", cnt, minionName, age);
						}
					}
					con.Close();
				}
				else
				{
					Console.WriteLine("No villain with ID {0} exists in the database.", villainId);
				}
			}
			catch (SqlException x)
			{
				Console.WriteLine(x.Message);
			}
		}
	}
}
