using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationListeners2
{
	class Program
	{
		static void Main(string[] args)
		{
			PasswordBox passwordBox = new PasswordBox();
			passwordBox.TextChanged += PasswordBox_TextChanged;
			Console.WriteLine("Enter your password:");
			while (true)
			{
				passwordBox.Text = Console.ReadLine();
			}
		}
		private static void PasswordBox_TextChanged(object sender, EventArgs e)
		{
			PasswordBox passwordBox = (PasswordBox)sender;
			if (passwordBox.Text.Length < 8)
			{
				Console.WriteLine("Password ust be at least 8 characters long.");
			}
			else if (!passwordBox.Text.Contains("$"))
			{
				Console.WriteLine("Password must contin at least one '$' character.");
			}
			else
			{
				Console.WriteLine("Password is invalid!");
			}
		}
	}
	class PasswordBox
	{
		public event EventHandler TextChanged;
		private string text;
		public string Text
		{
			get { return text; }
			set
			{
				if (text != value)
				{
					text = value;
					TextChanged?.Invoke(this, EventArgs.Empty);
				}
			}
		}
	}
}
