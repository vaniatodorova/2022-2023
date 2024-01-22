using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter the distance:");
			string distanceInput = Console.ReadLine();
			double distance = 0;
			try
			{
				distance = double.Parse(distanceInput);
			}
			catch (FormatException ex)
			{
				Console.WriteLine("Error: Invalid input.");
				return;
			}
			Console.WriteLine("Enter the source unit (km/mi):");
			string sourceUnit = Console.ReadLine();
			double factor = 0;
			string sourceName = "";
				switch (sourceUnit)
				{
					case "km":
						factor = 0.621371;
						sourceName = "kilometers";
						break;
					case "mi":
						factor = 1.60934;
						sourceName = "miles";
						break;
					default:
						Console.WriteLine("Error: Invalid input.");
						return;
				}
			Console.WriteLine("Enter the target unit (km/mi):");
			string targetUnit = Console.ReadLine();
			double targetFactor = 0;
			string targetName = "";
			switch (targetUnit)
				{
				case "km":
					targetFactor = 1;
					targetName = "kilometers";
					break;
				case "mi":
					targetFactor = 1.60934;
					targetName = "miles";
					break;
				default:
					Console.WriteLine("Error: Invalid input.");
					return;
				}
				double result = distance * factor / targetFactor;
				Console.WriteLine(distance + " " + sourceName + " is equal to " + result + " "+ targetName + ".");
			}
		}
}
