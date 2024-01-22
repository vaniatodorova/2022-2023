using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exception4
{
	class Program
	{
		static void Main()
		{
			string sourceFile = "source.txt";
			string destinationFile = "destination.txt";
			try
			{
				StreamReader sourceReader = new StreamReader(sourceFile);
				StreamWriter destinationWriter = new StreamWriter(destinationFile);
				string line;
				while ((line = sourceReader.ReadLine()) != null)
				{
					destinationWriter.WriteLine(line);
				}
				sourceReader.Close();
				destinationWriter.Close();
				Console.WriteLine("File copied successfully.");
			}
			catch (FileNotFoundException ex)
			{
				Console.WriteLine("Error: File not found.");
			}
			catch (IOException ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
		}
	}
}
