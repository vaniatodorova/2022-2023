using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationArguments4
{
	class Program
	{
		public delegate void GameEventHandler();
		public event GameEventHandler OnGameOver;
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the game!");
			Program obj = new Program();
			obj.OnGameOver += new GameEventHandler(obj_OnGameOver);
			bool gameOver = false;
			while (!gameOver)
			{
				Console.Write("Enter a command: ");
				string command = Console.ReadLine();
				if (command == "quit")
				{
					gameOver = true;
				}
			}
			if (obj.OnGameOver != null)
			{
				obj.OnGameOver();
			}
		}
		static void obj_OnGameOver()
		{
			Console.WriteLine("Game over!");
		}
	}
}
