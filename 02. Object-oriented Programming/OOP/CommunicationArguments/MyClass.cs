using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationArguments
{
	public class MyClass
	{
		public event EventHandler OnEvent;

		public void DoSomething()
		{
			if(OnEvent != null)
			{
				OnEvent(this, EventArgs.Empty);
			}
		}
	}
}
