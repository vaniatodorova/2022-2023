using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex08
{
	class RandomList : ArrayList
	{
		private ArrayList data;
        private Random rnd;
		public RandomList()
		{
			this.data = new ArrayList();
			data.Add("9");
			data.Add("7");
			data.Add("2");
			data.Add("5");
			data.Add("1");
		}
		public object RandomString()
		{
			int elementIndex = rnd.Next(0, data.Count - 1);
			string str = (string ) data[elementIndex];
			data.RemoveAt(elementIndex);
			return str;
		}
	
    }
}
