using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationListeners3
{
	class Program
	{
		static void Main(string[] args)
		{
			Keyboard keyboard = new Keyboard();
			keyboard.KeyPressed += Keyboard_KeyPressed;
			Console.WriteLine("Type something:");
			while (true)
			{
				ConsoleKeyInfo keyInfo = Console.ReadKey(true);
				keyboard.ProcessInput(keyInfo.KeyChar);
			}
		}
		private static void Keyboard_KeyPressed(object sender, KeyPressedEventArgs e)
		{
			Console.WriteLine("Key pressed: " + e.Key);
		}
	}
	class Keyboard
	{
		public event EventHandler<KeyPressedEventArgs> KeyPressed;
		public void ProcessInput(char input)
		{
			KeyPressed?.Invoke(this, new KeyPressedEventArgs(input));
		}
	}
	class KeyPressedEventArgs : EventArgs
	{
		public char Key { get; }
		public KeyPressedEventArgs(char key)
		{
			Key = key;
		}
	}
}
