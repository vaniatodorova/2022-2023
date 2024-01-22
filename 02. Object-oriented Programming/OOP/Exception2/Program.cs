using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exception2
{
	class Program
	{
		static void Main()
		{
			try
			{
				StreamReader reader = new StreamReader("input.txt");
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					Console.WriteLine(line);
				}
				reader.Close();
			}
			catch (FileNotFoundException ex)
			{
				Console.WriteLine("Error: File not found.");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error:" + ex.Message);
			}
		}
	}
}
