using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex09figure
{
	class Rectangle : IDrawable
	{
		public int width;
		public int heigth;
		public Rectangle(int figureWidth, int figureHeigth)
		{
			Width = figureWidth;
			Heigth = figureHeigth;
		}
		public int Width
		{
			get { return this.width; }
			set { this.width = value; }
		}
		public int Heigth
		{
			get { return this.heigth; }
			set { this.heigth = value; }
		}
		public void Draw()
		{

			DrawLine(this.Width, '*', '*');
			for (int i = 1; i < this.Heigth - 1; ++i)
			{
				DrawLine(this.Width, '*', ' ');
			}
			DrawLine(this.Width, '*', '*');
		}
		private void DrawLine(int width, char end, char mid)
	    {
			Console.Write(end);
			for(int i = 1; i < width - 1; ++i)
			{
				Console.Write(mid);
			}
			Console.WriteLine(end);
		}
		
	}
}
