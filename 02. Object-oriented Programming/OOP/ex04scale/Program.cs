using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04scale
{
	class Program
	{
		static void Main(string[] args)
		{
			Scale<int> scale = new Scale<int>(5,10);
			int havier=scale.GetHeavier();
			Console.WriteLine(havier);
			Scale<double> scale2 = new Scale<double>(22.4, 81.3);
			double havier2 = scale2.GetHeavier();
			Console.WriteLine(havier2);
		}
	}
}
