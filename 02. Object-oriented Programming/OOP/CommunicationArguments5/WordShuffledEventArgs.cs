using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationArguments5
{
	public class WordShuffledEventArgs : EventArgs
	{
		public int TimesShuffled { get; private set; }
		public WordShuffledEventArgs(int timesShuffled)
		{
			TimesShuffled = timesShuffled;
		}
	}
}
