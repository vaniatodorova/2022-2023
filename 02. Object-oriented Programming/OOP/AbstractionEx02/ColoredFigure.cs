using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionEx02
{
	abstract class ColoredFigure
	{
		public string color;
		public double size;
		public ColoredFigure(string figureColor, double figureSize)
		{
			Color = figureColor;
			Size = figureSize;
		}
		public string Color
		{
			get { return this.color; }
			set { this.color = value; }
		}
		public double Size
		{
			get { return this.size; }
			set { this.size = value; }
		}
		public abstract string GetName();
		public abstract double GetArea();

		public void Show()
		{
			Console.WriteLine("{0}:",GetName());
			Console.WriteLine("color: {0}", Color);
			Console.WriteLine("size: {0}", Size);
			string area = GetArea().ToString("F");
			area = String.Format("{0:0.00}", area);
			Console.WriteLine("Area: {0}", area);
		}
	}
}
