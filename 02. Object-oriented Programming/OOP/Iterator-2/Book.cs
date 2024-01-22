﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator_2
{
	public class Book
	{
		public Book(string title, int year, params string[] authors)
		{
			this.Title = title;
			this.Year = year;
			this.Authors = authors;
		}
		public string Title { get; set; }
		public int Year { get; set; }
		public IReadOnlyList<string> Authors { get; set; }
	}
}
