using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationArguments3
{
	class Program
	{
		public delegate bool ValidateInputDelegate(string input);
		public event ValidateInputDelegate OnValidateInput;
		static void Main(string[] args)
		{
			Program obj = new Program();
			obj.OnValidateInput+=new ValidateInputDelegate(obj_OnValidateInput);
		}
		static bool obj_OnValidateInput(string input)
		{
			return !string.IsNullOrEmpty(input);
		}
		public bool ValidateInput(string input)
		{
			if(OnValidateInput != null)
			{
				return OnValidateInput(input);
			}
			return true;
		}
	}
}
