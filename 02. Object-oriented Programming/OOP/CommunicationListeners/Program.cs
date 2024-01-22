using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationListeners
{
	class Program
	{
		static void Main(string[] args)
		{
			Button button = new Button();
			button.Click += Button_Click;
			Console.WriteLine("Click the button to count clicks.");
			while (true)
			{
				Console.ReadLine();
				button.PerformClick();
			}
		}
		private static void Button_Click(object sender, EventArgs e)
		{
			Console.WriteLine("Button Clicked!");
		}
	}
	class Button
	{
		public event EventHandler Click;
		public void PerformClick()
		{
			Click?.Invoke(this, EventArgs.Empty);
		}
	}
}
