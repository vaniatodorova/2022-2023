using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationArguments5
{
	public class WordShuffler
	{
		public event EventHandler<WordShuffledEventArgs> WordShuffled;
		public string Shuffle(string input)
		{
			List<char> characters = input.ToList();
			Random random = new Random();
			int timesShuffled = 0;
			while (timesShuffled < 100)
			{
				int index1 = random.Next(0, characters.Count);
				int index2 = random.Next(0, characters.Count);
				char temp = characters[index1];
				characters[index1] = characters[index2];
				characters[index2] = temp;
				timesShuffled++;
				if(WordShuffled != null)
				{
					WordShuffledEventArgs args = new WordShuffledEventArgs(timesShuffled);
					WordShuffled(this, args);
				}
			}
			return new string(characters.ToArray());
		}
	}
}
