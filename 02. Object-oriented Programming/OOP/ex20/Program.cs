﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex20
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.ReadLine().Split(new string[] { ", " },
				StringSplitOptions.RemoveEmptyEntries)
				.Select(double.Parse)
				.Select(n => n * 1.2)
				.ToList()
				.ForEach(n => Console.WriteLine($"{n:F2}"));
		}
	}
}
