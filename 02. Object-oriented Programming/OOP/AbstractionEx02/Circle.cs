﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionEx02
{
	class Circle : ColoredFigure
	{
		public Circle(string color, double size) : base(color, size)
		{}
		public override string GetName()
		{
			return ("Circle");
		}
		public override double GetArea()
		{
			return Math.PI * (Size * Size);
		}
	}
}
