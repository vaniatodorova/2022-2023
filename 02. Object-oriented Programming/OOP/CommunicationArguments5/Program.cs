using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationArguments5
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a word or a phrase:");
			string input = Console.ReadLine();
			WordShuffler shuffler = new WordShuffler();
			shuffler.WordShuffled += OnWordShuffled;
			string shuffled = shuffler.Shuffle(input);
			Console.WriteLine("Shuffled word or phrase: {0}", shuffled);
			Console.ReadLine();
		}
		static void OnWordShuffled(object sender, WordShuffledEventArgs e)
		{
			Console.WriteLine("Word or phrase shuffled {0} times.",e.TimesShuffled);
		}
	}
}
